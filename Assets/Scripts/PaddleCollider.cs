using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleCollider : MonoBehaviour {

    [SerializeField] Vector2 sideDirection = new Vector2(0, 0);

    private void OnCollisionEnter2D(Collision2D collsion)
    {
        transform.Translate(sideDirection);
    }
}
