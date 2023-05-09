using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Kill_Switch_Code : MonoBehaviour
{
    [SerializeField] TMP_InputField input_field;
    [SerializeField] GameObject ending_video_player, parent_canvas;

    public string decrypted_code;

    public void check_code()
    {
        if (input_field.text.ToUpper() == decrypted_code)
        {
            // Game Ending stuff here
            Debug.Log("ESCAPE ROOM COMPLETED!");
            GameSoundManager.PlaySound("PCLogin");
            parent_canvas.SetActive(false);
            ending_video_player.SetActive(true);
        }
    }
}
