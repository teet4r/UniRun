using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    void Awake()
    {
        instance = this;
    }

    #region Platform
    public Platform GetPlatform()
    {
        if (platformQ.Count == 0)
        {
            var platform = Instantiate(platformPrefab);
            platform.gameObject.SetActive(false);
            return platform;
        }
        return platformQ.Dequeue();
    }

    public void ReturnPlatform(Platform platform)
    {
        if (platform == null) return;
        platform.gameObject.SetActive(false);
        platformQ.Enqueue(platform);
    }
    #endregion

    public static ObjectPool instance = null;

    [Header("Prefabs")]
    [SerializeField]
    Platform platformPrefab;

    Queue<Platform> platformQ = new Queue<Platform>();
}
