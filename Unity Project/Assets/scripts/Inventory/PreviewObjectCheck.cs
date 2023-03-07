using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviewObjectCheck : MonoBehaviour
{
    Transform[] allchildren;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        allchildren = this.transform.GetComponentsInChildren<Transform>();
        for (int i = 0; i < allchildren.Length; i++)
        {
            if (allchildren[i].gameObject.layer != LayerMask.NameToLayer("Inspect"))
            {
                allchildren[i].gameObject.layer = LayerMask.NameToLayer("Inspect");
            }
        }
    }
}
