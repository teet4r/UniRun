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
    public float halfHeight { get; private set; } // 화면의 절반 높이
    public float halfWidth { get; private set; } // 화면의 절반 너비
    public Camera camera { get; private set; } // 카메라 컴포넌트
}
