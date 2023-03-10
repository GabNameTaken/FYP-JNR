using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(VideoConferenceSetupController))]
public class VideoConferenceSetupUI : MonoBehaviour
{
    [Header("Main Elements")]
    [SerializeField] GameObject openButton;
    [SerializeField] GameObject dropdownPanel;

    [Header("Dropdown Setup panel")]
    [SerializeField] GameObject setupPanel;
    [SerializeField] Toggle muteToggle;
    [SerializeField] Toggle videoToggle;

    [Header("Dropdown Conference panel")]
    [SerializeField] GameObject inConferencePanel;
    [SerializeField] Toggle muteToggleInConference;

    private VideoConferenceSetupController videoConferenceSetupController;

    #region unity messages

    private void Awake()
    {
        videoConferenceSetupController = GetComponent<VideoConferenceSetupController>();
    }
    private void OnEnable()
    {
        videoConferenceSetupController.onJoinedConference += OnJoinedConference;
        videoConferenceSetupController.onLeftConference += OnLeftConference;
        videoConferenceSetupController.onJoinedRoom += OnJoinedRoom;
        videoConferenceSetupController.onLeftRoom += OnLeftRoom;
        SceneManager.sceneLoaded += SceneManager_sceneLoaded;
    }

    private void OnDisable()
    {
        videoConferenceSetupController.onJoinedConference -= OnJoinedConference;
        videoConferenceSetupController.onLeftConference -= OnLeftConference;
        videoConferenceSetupController.onJoinedRoom -= OnJoinedRoom;
        videoConferenceSetupController.onLeftRoom -= OnLeftRoom;
        SceneManager.sceneLoaded -= SceneManager_sceneLoaded;
    }
    private void Start()
    {
        muteToggle.isOn = true;
        videoToggle.isOn = true;

        videoConferenceSetupController.MuteOnJoin = true;
        videoConferenceSetupController.VideoOnJoin = true;

        openButton.SetActive(false);
        dropdownPanel.SetActive(false);
    }

    #endregion

    private void SceneManager_sceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        //dk why but close button deosnt work if i leave drop down open
        openButton.SetActive(true);
        dropdownPanel.SetActive(false);
    }

    private void OnJoinedConference()
    {
        setupPanel.SetActive(false);
        inConferencePanel.SetActive(true);
        muteToggleInConference.isOn = videoConferenceSetupController.MuteOnJoin;
    }
    private void OnLeftConference()
    {
        setupPanel.SetActive(true);
        inConferencePanel.SetActive(false);
    }
    private void OnJoinedRoom()
    {
        openButton.SetActive(false);
        dropdownPanel.SetActive(true);
        setupPanel.SetActive(true);
        inConferencePanel.SetActive(false);
    }
    private void OnLeftRoom()
    {
        openButton.SetActive(false);
        dropdownPanel.SetActive(false);
    }

    public void OnPressed_ToggleMute(bool state)
    {
        videoConferenceSetupController.MuteOnJoin = state;
    }
    public void OnPressed_ToggleVideo(bool state)
    {
        videoConferenceSetupController.VideoOnJoin = state;
    }
    public void OnPressed_Join()
    {
        videoConferenceSetupController.JoinConference();
    }
    public void OnPressed_Leave()
    {
        videoConferenceSetupController.LeaveConference();
    }
    public void OnPressed_MuteInCall(bool state)
    {
        videoConferenceSetupController.MuteInCall(state);
    }
}
