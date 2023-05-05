using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyncArrows : MonoBehaviour
{
    [SerializeField] List<GameObject> ArrowsToSyncWith;
    private void OnEnable()
    {
        foreach (GameObject arrow in ArrowsToSyncWith)
        {
            arrow.SetActive(true);
        }
    }
}
