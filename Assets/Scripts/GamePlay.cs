using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlay : MonoBehaviour {

    public int lives = 5;
    public int blockCount;

    void Start ()
    {
        Cursor.visible = false;

        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "StartMenu" || currentScene.name == "GameOver")
        {
            Cursor.visible = true;
        }

        blockCount = GameObject.FindGameObjectsWithTag("Block").Length;

        spawnLifeBalls();
    }

    private void spawnLifeBalls()
    {

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