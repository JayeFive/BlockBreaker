using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleCollisionSound : MonoBehaviour {

    [SerializeField] AudioClip bounce;

    // Use this for initialization
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = bounce;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Ball"))
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
