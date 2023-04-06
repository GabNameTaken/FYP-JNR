using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCheese : MonoBehaviour
{
    private float speed = 0.002f;

    void Update()
    {
        if (this.gameObject.layer == LayerMask.NameToLayer("Inspect")) // Check if item is on Inspect Layer
        {
            if (this.gameObject.activeInHierarchy)
            {
                if (Input.GetKey(KeyCode.LeftArrow) && this.gameObject.transform.position.x >= -1)
                {//right
                    this.gameObject.transform.Translate(speed, 0, 0);
                }
                else if (Input.GetKey(KeyCode.RightArrow) && this.gameObject.transform.position.x <= 1)
                {//left
                    this.gameObject.transform.Translate(-speed, 0, 0);
                }
                else if (Input.GetKey(KeyCode.UpArrow) && this.gameObject.transform.position.y <= 1) //up y++
                {//left
                    this.gameObject.transform.Translate(0, -speed, 0);
                }
                else if (Input.GetKey(KeyCode.DownArrow) && this.gameObject.transform.position.y >= -1) //down y--
                {//right
                    this.gameObject.transform.Translate(0, speed, 0);
                }
            }
        }
    }
}
