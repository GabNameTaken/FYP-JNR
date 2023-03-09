using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct ScrollHelper<T> where T : Component
{
    public Transform content;
    public GameObject prefab;
    public List<T> spawnedPrefabComponents;

    public void FillContentWithCorrectNumberOfPrefabs(int count)
    {
        int i;
        for (i = 0; i < count; ++i)
        {
            // if we need more spawnedPrefabComponents
            if (i >= spawnedPrefabComponents.Count)
            {
                spawnedPrefabComponents.Add(Object.Instantiate(prefab, content).GetComponent<T>());
            }

            spawnedPrefabComponents[i].gameObject.SetActive(true);
        }

        SetGameObjectsFromIndexToInactive(i);
    }

    private void SetGameObjectsFromIndexToInactive(int index)
    {
        for (; index < spawnedPrefabComponents.Count; ++index)
        {
            spawnedPrefabComponents[index].gameObject.SetActive(false);
        }
    }
}
