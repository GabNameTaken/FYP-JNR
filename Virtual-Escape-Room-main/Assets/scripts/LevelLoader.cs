using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class LevelLoader : MonoBehaviourPunCallbacks
{
    public Animator transition;
    public float transitionTime = 1f;
    public string sceneName;

    public void LoadNextLevel(string sceneName)
    {
        this.sceneName = sceneName;
        if (gameObject.activeSelf)
        {
            StartCoroutine(LoadLevel());
        }
        else
            PhotonNetwork.LoadLevel(sceneName);
    }

    IEnumerator LoadLevel()
    {
        //play anim
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        //load scene
        PhotonNetwork.LoadLevel(sceneName);
    }
}