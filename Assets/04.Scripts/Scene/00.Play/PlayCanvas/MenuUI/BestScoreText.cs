using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScoreText : MonoBehaviour
{
    void Awake()
    {
        text = GetComponent<Text>();
    }

    void OnEnable()
    {
        text.text = bestScoreText + DBManager.bestScore.ToString();
    }

    Text text;

    readonly string bestScoreText = "Best Score: ";
}
