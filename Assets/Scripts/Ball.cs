using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    // config params
    [SerializeField] float startingXVector = 2.0f;
    [SerializeField] float startingYVector = 10.0f;
    [SerializeField] int sideForce = 500;
    [SerializeField] float maxSpeed = 17f;
    [SerializeField] Rigidbody2D rigidBody2d;

    // state
    bool hasStarted = false;

    // paddle position data
    Paddle paddle;
    float paddleXPos;
    Vector2 paddleToBallVector;

	// Use this for initialization
	void Start ()
    {
        paddle = GameObject.FindObjectOfType<Paddle>();
        paddleToBallVector = transform.position - paddle.transform.position;
        rigidBody2d = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        rigidBody2d.velocity = Vector2.ClampMagnitude(rigidBody2d.velocity, maxSpeed);

        if(!hasStarted)
        {
            LockBallToPaddle();
            LaunchOnMouseClick();
        }

        Vector2 ballPos = new Vector2(transform.position.x, transform.position.y);
    }

    private void LaunchOnMouseClick()
    {
        if (Input.GetMouseButton(0))
        {
            rigidBody2d.velocity = new Vector2(startingXVector, startingYVector);
            hasStarted = true;
        }
    }

    private void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
        transform.position = paddlePos + paddleToBallVector;
    }

    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Paddle"))
        {
            paddleXPos = paddle.transform.position.x;
            Vector2 distanceFromPaddleCenter = new Vector2(transform.position.x - paddleXPos, 100 / sideForce);
            rigidBody2d.AddForce(distanceFromPaddleCenter * sideForce);
        }
    }
}
