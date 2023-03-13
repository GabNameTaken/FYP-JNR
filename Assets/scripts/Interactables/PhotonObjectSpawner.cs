using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PhotonObjectSpawner : MonoBehaviour
{
    [SerializeField] List<GameObject> gameObjects;
    private PhotonView photonView;
    // Start is called before the first frame update
    void Start()
    {
        photonView = GetComponent<PhotonView>();

        foreach(GameObject gameObject in gameObjects)
        {
            photonView.RPC("SpawnObjectRPC", RpcTarget.AllViaServer, gameObject.name,gameObject.transform.position,gameObject.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [PunRPC]
    void SpawnObjectRPC(string objectName, Vector3 pos, Quaternion rotation)
    {
        GameObject obj = PhotonNetwork.Instantiate(objectName, pos, rotation);
        obj.name = objectName;
    }
}
