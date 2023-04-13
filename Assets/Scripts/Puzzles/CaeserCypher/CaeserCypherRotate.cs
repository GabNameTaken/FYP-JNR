using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaeserCypherRotate : MonoBehaviour
{
    private float speed = 0.4f;

    private void Update()
    {
        if (this.gameObject.layer == LayerMask.NameToLayer("Inspect")) // Check if item is on Inspect Layer
        {
            if (this.gameObject.activeInHierarchy)
            {
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    this.gameObject.transform.Rotate(0, speed, 0, Space.Self);
                }
                else if (Input.GetKey(KeyCode.RightArrow))
                {
                    this.gameObject.transform.Rotate(0, -speed, 0, Space.Self);
                }
            }
        }
    }
}
