using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCanvas : MonoBehaviour
{
    void Awake()
    {
        instance = this;
    }

    public static PlayCanvas instance = null;

    public JumpButton jumpButton;
}
