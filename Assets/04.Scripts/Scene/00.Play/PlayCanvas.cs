using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayCanvas : MonoBehaviour
{
    void Awake()
    {
        instance = this;
    }

    public void UIStart()
    {
        menuUI.SetActive(false);
        IngameUI.gameObject.SetActive(true);

        GameManager.instance.GameStart();
    }

    public static PlayCanvas instance = null;

    public GameObject menuUI;
    public IngameUI IngameUI;
    public GameObject gameOverUI;
}
