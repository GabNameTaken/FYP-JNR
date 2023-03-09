using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoConferenceControlPanel : MonoBehaviour
{
    [SerializeField] VideoConference videoConference;
    [SerializeField] Toggle audioToggle;
    [SerializeField] Toggle videoToggle;

    // Limitation: Can only set audio and video toggle state when not in conference due to ICall.Configure only being able to be called once.
    private void OnEnable()
    {
        audioToggle.isOn = false;
        videoToggle.isOn = false;

        videoConference.ToggleVideo(true);
    }

    public void OnPressed_ToggleVideo(bool state)
    {
        videoConference.ToggleVideo(true);
    }
}
