using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartBeatEffect : MonoBehaviour
{
    void Awake()
    {
        originScale = transform.localScale;
    }

    void OnEnable()
    {
        StartCoroutine(_HeartBeat());
    }

    IEnumerator _HeartBeat()
    {
        while (true)
        {
            // getting bigger
            for (float i = 0f; i <= maxScale; i += scaleDelta)
            {
                transform.localScale = originScale + new Vector3(i, i, 0f);
                yield return null;
            }
            for (float i = maxScale; i >= 0f; i -= scaleDelta)
            {
                transform.localScale = originScale + new Vector3(i, i, 0f);
                yield return null;
            }

            // getting smaller
            for (float i = 0f; i <= minScale; i += scaleDelta)
            {
                transform.localScale = originScale - new Vector3(i, i, 0f);
                yield return null;
            }
            for (float i = minScale; i >= 0f; i -= scaleDelta)
            {
                transform.localScale = originScale - new Vector3(i, i, 0f);
                yield return null;
            }
        }
    }

    [Header("Scale Variables")]
    [SerializeField]
    [Tooltip("���� ũ�� + maxScale���� scale ����")]
    float maxScale;
    [SerializeField]
    [Tooltip("���� ũ�� - minScale���� scale ����")]
    float minScale;

    [Header("Time Variables")]
    [SerializeField]
    float scaleDelta;

    Vector3 originScale;
}
