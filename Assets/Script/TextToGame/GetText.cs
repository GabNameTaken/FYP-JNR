using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using System.Linq;

public class GetText : MonoBehaviour
{
    [SerializeField] string content;
    [SerializeField] string folder;
    [SerializeField] TextMeshProUGUI recallTextObject;

    //public Transform contentWindow;

    // Start is called before the first frame update
    void Start()
    {
        string readFromFilePath = Application.streamingAssetsPath + "/InGameText/" + folder + content + ".txt";

        List<string> fileLines = File.ReadAllLines(readFromFilePath).ToList();

        foreach (string line in fileLines)
        {
            recallTextObject.text = line;
        }
    }

}