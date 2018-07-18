using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SoundDisable : MonoBehaviour
{
    bool soundDisabled = false;
    AudioSource bgMusic;
    AudioSource pop;
    AudioSource bounce;

    void Start ()
    {
        bgMusic = FindObjectOfType<MusicPlayer>().GetComponent<AudioSource>();

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            pop = FindObjectOfType<Ball>().GetComponent<AudioSource>();
            bounce = FindObjectOfType<Paddle>().GetComponent<AudioSource>();
        }
    }

    public void DisableSound()
    {
        if (!soundDisabled)
        {
            TurnOffMusic();
            TurnOffSounds();
            soundDisabled = true;
        }
        else if (soundDisabled)
        {
            TurnOnMusic();
            TurnOnSounds();
            soundDisabled = false;
        }
    }

    void TurnOffMusic ()
    {
        GetComponent<Image>().color = new Color(1, 1, 1, 0.5f);
        bgMusic.volume = 0;
    }

    void TurnOffSounds ()
    {
        if (pop != null)
        {
            pop.volume = 0;
            bounce.volume = 0;
        }
    }

    void TurnOnMusic()
    {
        GetComponent<Image>().color = new Color(1, 1, 1, 1);
        bgMusic.volume = 0.2f;
    }

    void TurnOnSounds ()
    {
        if (pop != null)
        {
            pop.volume = 0.2f;
            bounce.volume = 0.2f;
        }
    }
}
