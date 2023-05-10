using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DigitalRuby.SoundManagerNamespace;

public class GameSoundManager : MonoBehaviour
{
    static Dictionary<string, AudioSource> sounds = new();
    [SerializeField] List<string> soundNames;
    [SerializeField] AudioSource[] soundObjects;

    public Slider SoundSlider;

    void Awake()
    {
        for (int i = 0; i < soundNames.Count; ++i)
        {
            sounds.Add(soundNames[i], soundObjects[i]);
        }
    }

    public static void PlaySound(string soundName)
    {
        sounds[soundName].PlayOneShotSoundManaged(sounds[soundName].clip);
    }

    public static void PlaySoundLoop(string soundName)
    {
        sounds[soundName].PlayLoopingMusicManaged(1.0f, 1.0f, false);
    }

    public void SoundVolumeChanged()
    {
        SoundManager.SoundVolume = SoundSlider.value;
    }
}
