using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapeStop : MonoBehaviour {

    public float startingPitch = 1;
    public float timeToChange = 1;
    bool isTapeStopping = false;
    bool isTapeStarting = false;
    AudioSource bgMusic;

	// Use this for initialization
	void Start () {
        bgMusic = FindObjectOfType<MusicPlayer>().GetComponent<AudioSource>();
        bgMusic.pitch = startingPitch;
	}
	
	// Update is called once per frame
	void Update () {
		if (isTapeStopping)
        {
            StopTape();
        }

        if (isTapeStarting)
        {
            StartTape();
        }
    }

    public void InitiateTapeStop ()
    {
        isTapeStopping = true;
    }

    void StopTape ()
    {
        if (bgMusic.pitch > 0)
        {
            bgMusic.pitch -= Time.deltaTime * startingPitch / timeToChange;
        }
        else
        {
            isTapeStopping = false;
            isTapeStarting = true;
        }
    }

    void StartTape()
    {
        if (bgMusic.pitch < startingPitch)
        {
            bgMusic.pitch += Time.deltaTime * startingPitch / timeToChange;
        }
        else
        {
            isTapeStarting = false;
            bgMusic.pitch = startingPitch;
        }
    }
}
