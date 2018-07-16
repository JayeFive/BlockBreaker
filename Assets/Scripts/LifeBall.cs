using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeBall : MonoBehaviour {

    [SerializeField] GameObject lifeBall;
    [SerializeField] GamePlay gamePlay;
    List<GameObject> lifeBalls = new List<GameObject>();

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < gamePlay.extraLives; i++)
        {
            var newLifeBall = Instantiate(lifeBall, new Vector3(0.5f + i / 2.0f, 11.5f), Quaternion.identity);
            lifeBalls.Add(newLifeBall);
        }
    }

    public void RemoveLifeBall()
    {
        Destroy(lifeBalls[lifeBalls.Count - 1]);
        lifeBalls.RemoveAt(lifeBalls.Count - 1);
    }
}
