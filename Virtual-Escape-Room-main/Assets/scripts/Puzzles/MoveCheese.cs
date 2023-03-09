using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCheese : MonoBehaviour
{
    private float speed = 0.01f;

    void Update()
    {
        if (this.gameObject.activeInHierarchy)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {//right
                this.gameObject.transform.Translate(speed, 0, 0);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {//left
                this.gameObject.transform.Translate(-speed, 0, 0);
            }
            else if (Input.GetKey(KeyCode.UpArrow)) //up y++
            {//left
                this.gameObject.transform.Translate(0, speed, 0);
            }
            else if (Input.GetKey(KeyCode.DownArrow)) //down y--
            {//right
                this.gameObject.transform.Translate(0, -speed, 0);
            }
        }
    }
}
