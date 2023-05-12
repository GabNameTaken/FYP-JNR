using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Wiring : MonoBehaviour
{
    public Wire currentDraggedWire;
    public List<Wire> leftWireList;
    public List<Wire> rightWireList;

    private Dictionary<Wire, Wire> connectedPairs = new();

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
        Debug.Log(connectedPairs.Count);
        foreach (KeyValuePair<Wire, Wire> pair in connectedPairs)
        {
            if (pair.Value == wire)
                connectedPairs.Remove(pair.Value);

            Debug.Log(pair.Key + " : " + pair.Value);
            //    connectedPairs[pair.Key] = null;
        }
        Debug.Log(connectedPairs.Count);
    }
}
