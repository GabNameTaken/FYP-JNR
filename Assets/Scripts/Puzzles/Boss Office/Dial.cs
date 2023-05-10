using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dial : MonoBehaviour
{
    private char[] alphabet_list = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
    private int alphabet_list_length = 25; // 25 to account for 0 = first position of array

    [SerializeField] TMP_Text next_letter, current_letter, prev_letter;
    [SerializeField] GameObject knob;
    private int next_letter_array_pos;
    private int current_letter_array_pos;
    private int prev_letter_array_pos;

    // Start is called before the first frame update
    void Start()
    {
        next_letter_array_pos = 1; // 1 for letter B
        current_letter_array_pos = 0; // 0 for letter A
        prev_letter_array_pos = 25; // 25 for letter Z
    }

    public void click_next_letter()
    {
        GameSoundManager.PlaySound("SafeDial");
        // next_letter
        if (next_letter_array_pos + 1 > alphabet_list_length)
        {
            next_letter_array_pos = 0; // Loop back to A
            next_letter.text = alphabet_list[next_letter_array_pos].ToString();
        }
        else
        {
            next_letter_array_pos++; // Next letter
            next_letter.text = alphabet_list[next_letter_array_pos].ToString();
        }

        // current_letter
        if (current_letter_array_pos + 1 > alphabet_list_length)
        {
            current_letter_array_pos = 0; // Loop back to A
            current_letter.text = alphabet_list[current_letter_array_pos].ToString();
            knob.GetComponent<safe_puzzles_check>().checkcode();
        }
        else
        {
            current_letter_array_pos++; // Next letter
            current_letter.text = alphabet_list[current_letter_array_pos].ToString();
            knob.GetComponent<safe_puzzles_check>().checkcode();
        }

        // prev_letter
        if (prev_letter_array_pos + 1 > alphabet_list_length)
        {
            prev_letter_array_pos = 0; // Loop back to A
            prev_letter.text = alphabet_list[prev_letter_array_pos].ToString();
        }
        else
        {
            prev_letter_array_pos++; // Next letter
            prev_letter.text = alphabet_list[prev_letter_array_pos].ToString();
        }
    }

    public void click_prev_letter()
    {
        GameSoundManager.PlaySound("SafeDial");
        // next_letter
        if (next_letter_array_pos - 1 < 0)
        {
            next_letter_array_pos = alphabet_list_length; // Loop back to Z
            next_letter.text = alphabet_list[next_letter_array_pos].ToString();
        }
        else
        {
            next_letter_array_pos--; // Prev letter
            next_letter.text = alphabet_list[next_letter_array_pos].ToString();
        }

        // current_letter
        if (current_letter_array_pos - 1 < 0)
        {
            current_letter_array_pos = alphabet_list_length; // Loop back to Z
            current_letter.text = alphabet_list[current_letter_array_pos].ToString();
            knob.GetComponent<safe_puzzles_check>().checkcode();
        }
        else
        {
            current_letter_array_pos--; // Prev letter
            current_letter.text = alphabet_list[current_letter_array_pos].ToString();
            knob.GetComponent<safe_puzzles_check>().checkcode();
        }

        // prev_letter
        if (prev_letter_array_pos - 1 < 0)
        {
            prev_letter_array_pos = alphabet_list_length; // Loop back to Z
            prev_letter.text = alphabet_list[prev_letter_array_pos].ToString();
        }
        else
        {
            prev_letter_array_pos--; // Prev letter
            prev_letter.text = alphabet_list[prev_letter_array_pos].ToString();
        }
    }
}
