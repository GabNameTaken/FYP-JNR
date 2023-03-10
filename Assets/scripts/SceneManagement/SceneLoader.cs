using System;
using UnityEngine.SceneManagement;

public class SceneLoader
{
    [Serializable]
    public enum SceneBuildIndexes
    { // !*IMPORTANT*** Make sure this matches the scene list in the build settings
        startScene,
        gameScene,
    }
}