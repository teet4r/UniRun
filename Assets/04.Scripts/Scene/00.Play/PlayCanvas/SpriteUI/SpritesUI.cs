using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpritesUI : MonoBehaviour
{
    void Awake()
    {
        instance = this;
    }

    public void StartLoop()
    {
        for (int i = 0; i < sprites.Length; i++)
            sprites[i].StartLoop();
    }

    public void StopLoop()
    {
        for (int i = 0; i < sprites.Length; i++)
            sprites[i].StopLoop();
    }

    public static SpritesUI instance = null;

    public BackgroundLoop[] sprites;
}
