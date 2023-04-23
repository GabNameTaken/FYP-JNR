using Byn.Awrtc;
using Byn.Awrtc.Unity;
using Byn.Unity.Examples;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class VideoConference : MonoBehaviour, IVideoConferenceUIHandler
{
    public const int MAX_ROOM_NAME_LENGTH = 256;

    [SerializeField] MessageList output;
    [SerializeField] GameObject ObjectWithTypeIConferenceVideoOutputHandler;
    private IConferenceVideoOutputHandler conferenceVideoOutputHandler;

    private void OnValidate()
    {
        if (ObjectWithTypeIConferenceVideoOutputHandler.GetComponent<IVideoConferenceUIHandler>() != null)
        {
            Debug.LogError("Invalid Input for componentOfTypeIConferenceVideoOutputHandler");
        }
    }


    private ICall call;

    private MediaConfig mediaConfig = new();
    public MediaConfig MediaConfig { get => mediaConfig; set => mediaConfig = value; }

    private NetworkConfig netConfig = new();
    public NetworkConfig NetConfig { get => netConfig; set => netConfig = value; }

    readonly Dictionary<ConnectionId, string> idToUsername = new();

    public Dictionary<ConnectionId, string> callIDToUsername = new();
    public int ConnectionCount { get => idToUsername.Count; }


    private string ownUsername;
    private string roomName;

    private bool isMuteOnJoin;

    public delegate void ConferenceActivityEvent();
    public ConferenceActivityEvent onJoinedConference;
    public ConferenceActivityEvent onLeftConference;

    private void Awake()
    {
        conferenceVideoOutputHandler = ObjectWithTypeIConferenceVideoOutputHandler.GetComponent<IConferenceVideoOutputHandler>();
    }
    private void Start()
    {
        UnityCallFactory.RequestLogLevelStatic(UnityCallFactory.LogLevel.Info);
        UnityCallFactory.EnsureInit(OnCallFactoryReady, OnCallFactoryFailed);
    }
    /// <summary>
    /// The call object needs to be updated regularly to sync data received via webrtc with
    /// unity. All events will be triggered during the update method in the unity main thread
    /// to avoid multi threading errors
    /// </summary>
    private void Update()
    {
        if (call != null)
        {
            //update the call
            call.Update();
        }
    }
    private void OnDestroy()
    {
        CleanupCall();
    }

    private void OnCallFactoryReady()
    {
        ////to trigger android permission requests
        //StartCoroutine(ExampleGlobals.RequestPermissions());
        //use video and audio by default (the UI is toggled on by default as well it will change on click )
        MediaConfig.Video = false;
        MediaConfig.Audio = true;
        MediaConfig.VideoDeviceName = UnityCallFactory.Instance.GetDefaultVideoDevice();

        NetConfig.IceServers.Add(ExampleGlobals.DefaultIceServer);
        NetConfig.SignalingUrl = ExampleGlobals.SignalingConference;
        NetConfig.IsConference = true;
    }

    private void OnCallFactoryFailed(string error)
    {
        string fullErrorMsg = typeof(CallApp).Name + " can't start. The " + typeof(UnityCallFactory).Name + " failed to initialize with following error: " + error;
        Debug.LogError(fullErrorMsg);
    }

    private void Setup()
    {
        Append("Setting up ...");

        //setup the server
        Debug.Log("Creating ICall with " + NetConfig);
        call = UnityCallFactory.Instance.Create(NetConfig);
        if (call == null)
        {
            Append("Failed to create the call");
            return;
        }

        Append("Call created!");
        call.CallEvent += Call_CallEvent;

        //setup local video element
        conferenceVideoOutputHandler.AddUser(ConnectionId.INVALID);
        call.Configure(MediaConfig);
        call.SetMute(isMuteOnJoin);
        
        onJoinedConference?.Invoke();
    }

    private void Call_CallEvent(object sender, CallEventArgs e)
    {
        switch (e.Type)
        {
            case CallEventType.CallAccepted:
                //Outgoing call was successful or an incoming call arrived
                OnNewCall(e as CallAcceptedEventArgs);
                break;
            case CallEventType.CallEnded:
                OnCallEnded(e as CallEndedEventArgs);
                break;
            case CallEventType.ListeningFailed:
                Append("Failed to listen for incoming calls! Server might be down!");
                ResetCall();
                break;

            case CallEventType.ConnectionFailed:
                {
                    //this should be impossible to happen in conference mode!
                    ErrorEventArgs args = e as ErrorEventArgs;
                    Append("Error: " + args.Info);
                    Debug.LogError(args.Info);
                    ResetCall();
                }
                break;

            case CallEventType.FrameUpdate:
                //new frame received from webrtc (either from local camera or network)
                FrameUpdateEventArgs frameargs = e as FrameUpdateEventArgs;
                conferenceVideoOutputHandler.UpdateFrame(frameargs);
                break;
            case CallEventType.Message:
                {
                    //text message received
                    MessageEventArgs args = e as MessageEventArgs;

                    //due to timing issues it can happen that a message arrives before we get the NewUser notification
                    //if we get a message from a not yet known user we add them here
                    if (idToUsername.ContainsKey(args.ConnectionId) == false)
                    {
                        AddNewConnection(args.ConnectionId);
                    }

                    if (idToUsername[args.ConnectionId] == "unknown")
                    {
                        //don't know this user yet. First message is expected to be their username
                        string name = args.Content;
                        OnNewUserDiscovered(name, args.ConnectionId);
                    }
                    else
                    {
                        //known user so we likely got a regular text message form them
                        string name = idToUsername[args.ConnectionId];
                        Append(name + ":" + args.Content);
                    }
                    break;
                }
            case CallEventType.WaitForIncomingCall:
                {
                    //the chat app will wait for another app to connect via the same string
                    WaitForIncomingCallEventArgs args = e as WaitForIncomingCallEventArgs;
                    Append("Waiting for incoming call address: " + args.Address);
                    break;
                }
        }

    }

    private void OnNewCall(CallAcceptedEventArgs args)
    {
        conferenceVideoOutputHandler.AddUser(args.ConnectionId);
        AddNewConnection(args.ConnectionId);
        //let them know our username!
        call.Send(ownUsername);
    }
    private void AddNewConnection(ConnectionId id)
    {
        //new connection. we do not know who that is yet until we get the first message!
        if (idToUsername.ContainsKey(id) == false)
        {
            idToUsername[id] = "unknown";
            Append("New connection with ID " + id + " username not yet known");
        }

    }
    private void OnNewUserDiscovered(string name, ConnectionId id)
    {
        Debug.Log("Received first message from ConnectionId " + id + "! Their username is " + name);
        //store for later use
        idToUsername[id] = name;
        Append("New user discovered name: " + name + " and connection id: " + id);
    }
    private void OnCallEnded(CallEndedEventArgs args)
    {
        conferenceVideoOutputHandler.RemoveUser(args.ConnectionId);
        OnUserLeft(args.ConnectionId);
    }
    private void OnUserLeft(ConnectionId id)
    {
        if (idToUsername.ContainsKey(id))
        {
            string name = idToUsername[id];
            Append("User with name " + name + " and local ID " + id + " got disconnected");
        }
    }

    private void ResetCall()
    {
        conferenceVideoOutputHandler.RemoveAllUsers();

        onLeftConference?.Invoke();

        CleanupCall();
    }
    private void CleanupCall()
    {
        if (call != null)
        {

            Debug.Log("Destroying call!");
            call.Dispose();
            call = null;
            Debug.Log("Call destroyed");
        }
    }

    private void Append(string text)
    {
        if (output != null)
        {
            output.AddTextEntry(text);
        }
        else
        {
            Debug.Log("Chat: " + text);
        }
    }

    #region Implement IVideoConferenceUIHandler
    public void JoinConference()
    {
        Setup();
        call.Listen(roomName);
    }

    public void LeaveConference()
    {
        ResetCall();
    }
    public void SetUsername(string username)
    {
        ownUsername = username;
    }

    public string GetUsername(ConnectionId id)
    {
        return ownUsername;
    }

    public void SetRoomName(string roomName)
    {
        if (roomName.Length > MAX_ROOM_NAME_LENGTH)
        {
            roomName = roomName.Substring(0, MAX_ROOM_NAME_LENGTH);
        }

        this.roomName = roomName;
    }
    public void ToggleMute(bool state)
    {
        if (call != null)
        {
            call.SetMute(state);
        }
        else
        {
            isMuteOnJoin = state;
        }
    }

    public void ToggleVideo(bool state)
    {
        MediaConfig.Video = state;
    }

    #endregion
}
