using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCollisionSound : MonoBehaviour {

    [SerializeField] AudioClip pop;

    // Use this for initialization
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = pop;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Block"))
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
