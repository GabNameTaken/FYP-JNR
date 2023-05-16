using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DigitalRuby.SoundManagerNamespace;

public class GameSoundManager : MonoBehaviour
{
    public static GameSoundManager instance;

    Dictionary<string, AudioSource> sounds = new();
    [SerializeField] List<string> soundNames;
    [SerializeField] AudioSource[] soundObjects;

    public Slider SoundSlider;

    void Awake()
    {
        if (instance)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        for (int i = 0; i < soundNames.Count; ++i)
        {
            sounds.Add(soundNames[i], soundObjects[i]);
        }
    }

    public void PlaySound(string soundName)
    {
        sounds[soundName].PlayOneShotSoundManaged(sounds[soundName].clip);
    }

    public void PlaySoundLoop(string soundName)
    {
        sounds[soundName].PlayLoopingMusicManaged(1.0f, 1.0f, false);
    }

    public void SoundVolumeChanged()
    {
        SoundManager.SoundVolume = SoundSlider.value;
    }
}
