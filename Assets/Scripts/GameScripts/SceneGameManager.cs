using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SceneGameManager : MonoBehaviourPunCallbacks
{
    private PhotonView photonView;
    private GameObject thisPlayer;
    [SerializeField] GameObject previewObject;
    [SerializeField] GameObject GameOverCanvas;
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

    public PhotonView GetPlayerPhotonView()
    {
        return photonView;
    }

    public void EndGame(bool win)
    {
        if (!win)
        {
            GameOverCanvas.GetComponent<CanvasToggle>().SetCanvasToActive();
        }
    }
}
