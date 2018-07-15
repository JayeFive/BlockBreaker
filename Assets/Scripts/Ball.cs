using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    // config params
    Paddle paddle1;
    [SerializeField] float startingXVector = 2.0f;
    [SerializeField] float startingYVector = 10.0f;


    // state
    Vector2 paddleToBallVector;
    bool hasStarted = false;


	// Use this for initialization
	void Start ()
    {
        paddle1 = GameObject.FindObjectOfType<Paddle>();
        paddleToBallVector = transform.position - paddle1.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(!hasStarted)
        {
            LockBallToPaddle();
            LaunchOnMouseClick();
        }
    }

    private void LaunchOnMouseClick()
    {
        if (Input.GetMouseButton(0))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(startingXVector, startingYVector);
            hasStarted = true;
        }
    }

    private void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePos + paddleToBallVector;
    }
}
