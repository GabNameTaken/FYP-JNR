using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct ObjectPooler<T> where T : Component
{
    public Transform parent;
    public GameObject prefab;
    public List<GameObject> gameObjects;
    public List<T> components;
    public int initialSize;
    public bool isControllerInChild;

    public void Initialize()
    {
        // initialize the pool
        if (gameObjects == null)
            gameObjects = new List<GameObject>();

        if (components == null)
            components = new List<T>();

        AddToPool();
    }

    private void AddToPool()
    {
        for (int i = 0; i < initialSize; ++i)
        {
            GameObject spawn = UnityEngine.Object.Instantiate(prefab, parent);

            T component;

            if (isControllerInChild)
            {
                component = spawn.GetComponentInChildren<T>();
            }
            else
            {
                component = spawn.GetComponent<T>();
            }

            gameObjects.Add(spawn);

            components.Add(component);

            // set it to inactive
            spawn.SetActive(false);
        }

    }

    public KeyValuePair<GameObject, T> FetchInstance()
    {
        // search for the first inactive object
        for (int i = 0; i < gameObjects.Count; ++i)
        {
            // if it's active we don't want it
            if (gameObjects[i].activeSelf)
            {
                continue;
            }

            // is inactive
            gameObjects[i].SetActive(true);

            // since at they are ordered in the same order gameObjects and controllers
            // we can conveniently use i to denote the controller
            return new KeyValuePair<GameObject, T>(gameObjects[i], components[i]);
        }

        AddToPool(); // add more to the pool

        return FetchInstance();
    }

    public T FetchComponent()
    {
        // search for the first inactive object
        for (int i = 0; i < gameObjects.Count; ++i)
        {
            // if it's active we don't want it
            if (gameObjects[i].activeSelf)
            {
                continue;
            }

            gameObjects[i].SetActive(true);

            // since at they are ordered in the same order main and controllers
            // we can conveniently use i to denote the controller
            return components[i];

        }

        AddToPool(); // add more to the pool

        return FetchComponent();
    }

    public GameObject FetchGO()
    {

        // search for the first inactive object
        for (int i = 0; i < gameObjects.Count; ++i)
        {
            // if it's active we don't want it
            if (gameObjects[i].activeSelf)
            {
                continue;
            }

            // is inactive
            gameObjects[i].SetActive(true);

            return gameObjects[i];

        }

        AddToPool(); // add more to the pool

        return FetchGO();
    }
    public static void ReturnGO(GameObject mainParent)
    {
        mainParent.SetActive(false);
    }
}
