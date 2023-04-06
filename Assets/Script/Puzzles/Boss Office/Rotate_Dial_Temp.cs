using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Dial_Temp : MonoBehaviour
{
    public char dial_letter;
    [SerializeField] GameObject dial;
    
    private float dial_target_rotation;
    //private bool scroll_up_check;
    //private bool scroll_down_check;
    private bool is_scrolling;

    private bool rotation_reset_check_up;
    private bool rotation_reset_check_down;


    private float rotate_amount;

    // Start is called before the first frame update
    void Start()
    {
        //is_scrolling = false;
        //dial_target_rotation = 0;
        //rotation_reset_check_up = rotation_reset_check_down = false;

        rotate_amount = 360 / 26;
    }

    // Update is called once per frame
    void Update()
    {
        //if (dial.transform.eulerAngles.z == dial_target_rotation)
        //{
        //    is_scrolling = false;
        //}

        //else
        //{
        //    is_scrolling = true;
        //}

        //if (rotation_reset_check_up) // Reset rotation for positive rotation
        //{
        //    dial.transform.Rotate(0, 0, (dial.transform.eulerAngles.z - (-360)));
        //    rotation_reset_check_up = false;
        //}
        //if (dial.transform.eulerAngles.z < dial_target_rotation && is_scrolling == true) // scroll up for next letter to go up
        //{
        //    Debug.Log(dial.transform.eulerAngles.z);
        //    dial.transform.Rotate(0, 0, (360/26));
        //    if (dial.transform.eulerAngles.z >= dial_target_rotation)
        //    {
        //        dial.transform.transform.Rotate(0, 0, -(dial.transform.eulerAngles.z - dial_target_rotation));
        //        is_scrolling = false;
        //    }
        //}


        //if (rotation_reset_check_down) // Reset rotation for negative rotation
        //{
        //    dial.transform.Rotate(0, 0, (dial.transform.eulerAngles.z - (-360)));
        //    rotation_reset_check_down = false;
        //}
        //if (dial.transform.eulerAngles.z > dial_target_rotation && is_scrolling == true) // scroll down for prev letter to go down
        //{
        //    Debug.Log(dial.transform.eulerAngles.z);
        //    dial.transform.Rotate(0, 0, -(360 / 26));
        //    if (dial.transform.eulerAngles.z <= dial_target_rotation)
        //    {
        //        dial.transform.transform.Rotate(0, 0, -(dial.transform.eulerAngles.z - dial_target_rotation));
        //        is_scrolling = false;
        //    }
        //}
    }

    public void scroll_up() // scroll up for next letter to go up
    {
        //if (!is_scrolling)
        //{
        //    // prev letter
        //    //scroll_up_check = true;
        //    dial_target_rotation += (360 / 26);
        //    Debug.Log(dial_target_rotation);

        //    if (dial_target_rotation >= 360)  // Reset rotation to zero upon reaching 360 degrees full rotation
        //    {
        //        dial_target_rotation = 0;
        //        rotation_reset_check_up = true;
        //    }
        //}

        dial.transform.Rotate(0, 0, rotate_amount);
    }

    public void scroll_down() // scroll down for prev letter to go down
    {
        //if (!is_scrolling)
        //{
        //    // next letter
        //    //scroll_down_check = true;
        //    dial_target_rotation -= (360 / 26);
        //    Debug.Log(dial_target_rotation);

        //    if (dial_target_rotation <= -360)  // Reset rotation to zero upon reaching 360 degrees full rotation
        //    {
        //        dial_target_rotation = 0;
        //        rotation_reset_check_down = true;
        //    }
        //}

        dial.transform.Rotate(0, 0, -rotate_amount);
    }
}
