using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCamera
{
    public static float halfHeight { get; private set; } = Camera.main.orthographicSize;
    public static float halfWidth { get; private set; } = Camera.main.orthographicSize * Camera.main.aspect;
}
