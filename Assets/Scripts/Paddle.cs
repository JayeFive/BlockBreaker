using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    // Config params

    [SerializeField] float screenWidthInUnits = 16.0f;
    [SerializeField] float clamp_left = 1f;
    [SerializeField] float clamp_right = 15f;

    // Update is called once per frame
    void Update () {
        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosInUnits, clamp_left, clamp_right);
        transform.position = paddlePos;
	}
}
