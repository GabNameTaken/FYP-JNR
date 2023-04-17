using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SceneGameManager : MonoBehaviourPunCallbacks
{
    private PhotonView photonView;
    private GameObject thisPlayer;
    public override void OnEnable()
    {
        base.OnEnable();

        if (PhotonNetwork.InRoom)
        {
            OnJoinedRoom();
        }
    }
    public override void OnJoinedRoom()
    {
        StartGame();
    }

    private void StartGame()
    {
        thisPlayer = PhotonNetwork.Instantiate("Player", new Vector3(0, 0, 0), Quaternion.identity);
        photonView = thisPlayer.GetPhotonView();
    }

    public void SyncItems()
    {
        CItem[] items = FindObjectsOfType<CItem>(true);
        foreach(CItem item in items)
        {
            PhotonView view = item.GetComponent<PhotonView>();
            if (view != null)
            {
                if (item.getbIsPickedUp())
                {
                    //item.AddToInventory();
                    Debug.Log("added: " + item.getstrItemName());
                }
                else
                {
                    Debug.Log(item.getstrItemName() + " not picked up");
                }
            }
            else
            {
                //item.gameObject.SetActive(!item.getbIsPickedUp());
                Debug.Log(item.getstrItemName() + " not picked up");
            }
        }
    }


    public PhotonView GetPlayerPhotonView()
    {
        return photonView;
    }
}
