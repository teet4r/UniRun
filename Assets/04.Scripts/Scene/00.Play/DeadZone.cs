using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    void Awake()
    {
        transform.position = new Vector3(0f, -MainCamera.halfHeight - 3f);
    }
}
