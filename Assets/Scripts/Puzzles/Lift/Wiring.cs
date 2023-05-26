using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Wiring : MonoBehaviour
{
    public Wire currentDraggedWire;
    public Wire currentHoveredWire;
    public List<Wire> leftWireList;
    public List<Wire> rightWireList;

    [Header("Solutions")] 
    public List<Wire> LeftWireSolutionList;
    public List<Wire> RightWireSolutionList;
    public GameObject navigationReward;

    private Dictionary<Wire, Wire> connectedPairs = new();

    [SerializeField] Hints hintRef;

    private void Start()
    {
        foreach (Transform child in transform.GetChild(0))
        {
            leftWireList.Add(child.GetComponent<Wire>());
            child.GetComponent<Wire>().isLeftWire = true;
        }
        foreach (Transform child in transform.GetChild(1))
        {
            rightWireList.Add(child.GetComponent<Wire>());
        }
    }

    public void ConnectPair(Wire wire1, Wire wire2)
    {
        connectedPairs[wire1] = wire2;
        connectedPairs[wire2] = wire1;
        GameSoundManager.instance.PlaySound("LiftWire");

        if (CheckSolution())
            Solved();
    }

    public bool CheckConnection(Wire wire)
    {
        return connectedPairs.ContainsKey(wire);
    }

    public void RemovePair(Wire wire1, Wire wire2)
    {
        connectedPairs[wire1] = null;
        connectedPairs[wire2] = null;
    }

    public void RemoveWire(Wire wire)
    {
        Wire connectedWire = null;
        if (connectedPairs[wire])
        {
            connectedWire = connectedPairs[wire];
        }
        if (connectedWire != null)
        {
            connectedPairs.Remove(connectedWire);
        }
        connectedPairs.Remove(wire);
    }

    private bool CheckPair(Wire wire1, Wire wire2)
    {
        if (connectedPairs.ContainsKey(wire1) && connectedPairs.ContainsKey(wire2))
        {
            if (connectedPairs[wire1] == wire2 && connectedPairs[wire2] == wire1)
                return true;
        }
        return false;
    }
    private bool CheckSolution()
    {
        for (byte i = 0; i < LeftWireSolutionList.Count; i++)
        {
            if (!CheckPair(LeftWireSolutionList[i], RightWireSolutionList[i]))
                return false;
        }
        return true;
    }

    private void Solved()
    {
        navigationReward.SetActive(true);
        QueuedNotification.NotificationInfo notificationInfo = new();
        notificationInfo.title = "Objective: ";
        notificationInfo.message = "Lift Panel fixed";
        notificationInfo.durationSeconds = 5;
        QueuedNotification.instance.QueueNotification(notificationInfo);
        hintRef.CompletedPuzzle("Wire");
        GameSoundManager.instance.PlaySound("LiftPing");
    }
}
