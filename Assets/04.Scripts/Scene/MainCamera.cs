using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    void Awake()
    {
        instance = this;

        camera = GetComponent<Camera>();

        halfHeight = Camera.main.orthographicSize;
        halfWidth = halfHeight * Camera.main.aspect;
    }

    public static MainCamera instance = null;
    public float halfHeight { get; private set; }
    public float halfWidth { get; private set; }
    public Camera camera { get; private set; }
}
