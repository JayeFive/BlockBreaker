using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    [SerializeField] int maxHits = 1;
    int timesHit = 0;
    GamePlay gamePlay;

    void Start ()
    {
        gamePlay = GameObject.FindObjectOfType<GamePlay>();
    }

    private void OnCollisionEnter2D (Collision2D collision)
    {
        timesHit++;

        if (timesHit == maxHits)
        {
            Destroy(gameObject);
            UpdateBlockCount();
        }
    }

    private void UpdateBlockCount ()
    {
        gamePlay.blockCount--;
        gamePlay.CheckForSceneWin();
    }
}
