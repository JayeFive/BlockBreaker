using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class StartButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler {

    [SerializeField] SceneLoader sceneLoader;

    public void OnPointerEnter(PointerEventData eventData)
    {
        GetComponent<Transform>().localScale = new Vector2(1.05f, 1.05f);
        GetComponent<Text>().color = new Color32(255, 138, 138, 255);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        GetComponent<Transform>().localScale = new Vector2(1.0f, 1.0f);
        GetComponent<Text>().color = new Color(0, 0, 0, 1);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        sceneLoader.LoadNextScene();
    }
}
