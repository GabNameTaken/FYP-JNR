using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneArrow : InteractableObject
{
    private SceneNavigation sceneNavigation;

    private void Start()
    {
        sceneNavigation = transform.parent.GetComponent<SceneNavigation>();
    }

    public override void OnClick()
    {
        sceneNavigation.ChangeSceneWithSceneName(name);
    }
}
