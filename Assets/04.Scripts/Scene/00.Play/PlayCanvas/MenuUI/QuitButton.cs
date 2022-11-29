using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Image))]
public class QuitButton : MonoBehaviour
{
    void Awake()
    {
        image = GetComponent<Image>();
        button = GetComponent<Button>();
    }

    public void Quit()
    {
        Application.Quit();
    }

    Image image;
    Button button;
}
