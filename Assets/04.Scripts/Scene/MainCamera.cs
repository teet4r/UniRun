using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCamera
{
    public static readonly float halfHeight = Camera.main.orthographicSize; // ȭ���� ���� ����
    public static readonly float halfWidth = halfHeight * Camera.main.aspect; // ȭ���� ���� �ʺ�
}
