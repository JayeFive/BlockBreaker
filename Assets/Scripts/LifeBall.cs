using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeBall : MonoBehaviour {

    [SerializeField] GameObject lifeBall;
    GamePlay gamePlay;

    // Use this for initialization
    void Start()
    {
        gamePlay = FindObjectOfType<GamePlay>();

        for (int i = 0; i < gamePlay.lives; i++)
        {
            Instantiate(lifeBall, new Vector3(0.5f + i / 2.0f, 11.25f), Quaternion.identity);
        }
    }

    public void RemoveLifeBall()
    {

    }
}
