using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour {

    public int extraLives = 3;
    public int blockCount;
    public Text blockCounterText;

    void Start ()
    {
        Cursor.visible = true;

        //Scene currentScene = SceneManager.GetActiveScene();
        //if (currentScene.buildIndex == 1)
        //{
        //    Cursor.visible = false;
        //}

        blockCount = GameObject.FindGameObjectsWithTag("Block").Length;
    }

    private void Update()
    {
        if (blockCounterText != null)
        {
            blockCounterText.text = blockCount.ToString();
        }
    }

    public void CheckForSceneWin ()
    {
        if (blockCount == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}