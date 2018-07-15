﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlay : MonoBehaviour {

    public int blockCount;

    void Start ()
    {
        blockCount = GameObject.FindGameObjectsWithTag("Block").Length;
    }

    public void CheckForSceneWin ()
    {
        if (blockCount == 0)
        {
            Debug.Log("Checked for win");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}