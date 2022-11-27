using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    void Awake()
    {
        text = GetComponent<Text>();
    }

    public void Update_(int score)
    {
        text.text = scoreText + score.ToString();
    }

    Text text;

    readonly string scoreText = "Score: ";
}
