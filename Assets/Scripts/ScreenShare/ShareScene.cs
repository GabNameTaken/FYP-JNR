using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using ExitGames.Client.Photon;

public class ShareScene : MonoBehaviour
{
    public Dictionary<string, bool> activeScenes = new();
    public Dictionary<string, bool> activeItems = new();
    public GameObject scenes;
    public GameObject items;

    private void Start()
    {
        ResetActiveDictionary(activeScenes, scenes);
        ResetActiveDictionary(activeItems, items);
    }

    private bool CheckActives(GameObject parent, Dictionary<string,bool> dictionary)
    {
        for (int i = 0; i < parent.transform.childCount; i++)
        {
            bool checkDictionary = dictionary[parent.transform.GetChild(i).name];
            bool checkChild = parent.transform.GetChild(i).gameObject.activeSelf;

            if (checkChild != checkDictionary)
            {
                return true;
            }
        }
        return false;
    }

    private void ResetActiveDictionary(Dictionary<string,bool> dictionary, GameObject reference)
    {
        dictionary.Clear();
        for (int i = 0; i < reference.transform.childCount; i++)
        {
            dictionary.Add(reference.transform.GetChild(i).name, reference.transform.GetChild(i).gameObject.activeSelf);
        }
        Debug.Log(dictionary);
    }

    public Dictionary<string,bool> SaveActiveScenes(string dictionary)
    {
        if (dictionary == "scenes")
        {
            ResetActiveDictionary(activeScenes, scenes);
            return activeScenes;
        }
        else if (dictionary == "items")
        {
            ResetActiveDictionary(activeItems, items);
            return activeItems;
        }
        return null;
    }

    public void SetActiveScenes(Dictionary<string,bool> newActiveScenes, Dictionary<string,bool> newActiveItems)
    {
        foreach (GameObject scene in scenes.transform)
        {
            scene.SetActive(newActiveScenes[scene.name]);
        }
        foreach (GameObject item in items.transform)
        {
            items.SetActive(newActiveItems[items.name]);
        }
    }

    public void Share(List<Player> listOfViewers)
    {
        int[] receivers = new int[listOfViewers.Count];
        for (int i = 0; i < listOfViewers.Count; i++)
        {
            receivers[i] = listOfViewers[i].ActorNumber;
        }

        if (CheckActives(scenes, activeScenes))
        {
            ResetActiveDictionary(activeScenes, scenes);
            ResetActiveDictionary(activeItems, items);
            Debug.Log("Raising event for sending scenes");
            object[] content = { activeScenes , activeItems};
            PhotonNetwork.RaiseEvent(RaiseEventManager.sendScene, content, new RaiseEventOptions { TargetActors = receivers }, SendOptions.SendReliable);
        }
    }
}
