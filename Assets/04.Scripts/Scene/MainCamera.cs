using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCamera
{
    public static readonly float halfHeight = Camera.main.orthographicSize; // 화면의 절반 높이
    public static readonly float halfWidth = halfHeight * Camera.main.aspect; // 화면의 절반 너비
}
