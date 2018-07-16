using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    // config params
    [SerializeField] float startingXVector = 2.0f;
    [SerializeField] float startingYVector = 10.0f;
    [SerializeField] int sideForce = 500;
    [SerializeField] Rigidbody2D rb;


    // state
    Vector2 paddleToBallVector;
    bool hasStarted = false;

    // paddle position data
    Paddle paddle1;
    float paddleXPos;

	// Use this for initialization
	void Start ()
    {
        paddle1 = GameObject.FindObjectOfType<Paddle>();
        paddleToBallVector = transform.position - paddle1.transform.position;
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update ()
    {
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
            GetComponent<Rigidbody2D>().velocity = new Vector2(startingXVector, startingYVector);
            hasStarted = true;
        }
    }

    private void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePos + paddleToBallVector;
    }

    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Paddle") == true)
        {
            paddleXPos = paddle1.transform.position.x;
            Vector2 distanceFromPaddleCenter = new Vector2(transform.position.x - paddleXPos, 0);
            rb.AddForce(distanceFromPaddleCenter * sideForce);
        }
    }
}
