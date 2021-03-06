﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoseCollider : MonoBehaviour {
    [SerializeField] GamePlay gamePlay;
    [SerializeField] LifeBall lifeBall;
    [SerializeField] Ball ball;
    [SerializeField] Paddle paddle;
    [SerializeField] TapeStop tapeStop;

    private void OnTriggerEnter2D (Collider2D collision)
    {
        tapeStop.InitiateTapeStop();
        UpdateLives();
        ResetPaddleAndBall();
    }

    private void UpdateLives()
    {
        if (gamePlay.extraLives > 0)
        {
            gamePlay.extraLives--;
            lifeBall.RemoveLifeBall();
        }
        else
        {
            SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings - 1);
        }
    }

    private void ResetPaddleAndBall()
    {
        Vector2 resetPos = new Vector2(paddle.transform.position.x, paddle.transform.position.y + 0.33f);
        ball.transform.position = resetPos;
        ball.hasStarted = false;
    }
}
