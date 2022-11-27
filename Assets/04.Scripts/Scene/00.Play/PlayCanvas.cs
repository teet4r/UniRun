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
        jumpButton.gameObject.SetActive(true);
        scoreText.gameObject.SetActive(true);
        GameManager.instance.GameStart();
    }

    public static PlayCanvas instance = null;

    public JumpButton jumpButton;
    public ScoreText scoreText;
    public GameObject gameOverUI;
    public GameObject menuUI;
}
