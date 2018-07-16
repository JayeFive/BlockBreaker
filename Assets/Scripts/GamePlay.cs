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
        Cursor.visible = false;

        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "StartMenu" || currentScene.name == "GameOver")
        {
            Cursor.visible = true;
        }

        blockCount = GameObject.FindGameObjectsWithTag("Block").Length;
    }

    private void Update()
    {
        blockCounterText.text = blockCount.ToString();
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