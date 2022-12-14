using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Bgm
{
    BGM1
}

[RequireComponent(typeof(AudioSource))]
public class BgmAudio : MonoBehaviour
{
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();

        Initialize();
    }

    void Start()
    {
        Play(Bgm.BGM1);
    }

    #region Play Functions
    public void Play(string clipName, bool loop = true)
    {
        if (!clipIndexOf.ContainsKey(clipName)) return;
        audioSource.clip = clips[clipIndexOf[clipName]];
        audioSource.loop = loop;
        audioSource.Play();
    }

    public void Play(Bgm bgm, bool loop = true)
    {
        audioSource.clip = clips[(int)bgm];
        audioSource.loop = loop;
        audioSource.Play();
    }
    #endregion

    void Initialize()
    {
        for (int i = 0; i < clips.Length; i++)
            clipIndexOf.Add(clips[i].name, i);
    }

    public bool mute
    {
        get { return audioSource.mute; }
        set { audioSource.mute = value; }
    }

    [SerializeField]
    AudioClip[] clips;

    AudioSource audioSource;
    Dictionary<string, int> clipIndexOf = new Dictionary<string, int>();
}
