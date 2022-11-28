using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Sfx
{
    JUMP, DIE
}

[RequireComponent(typeof(AudioSource))]
public class SfxAudio : MonoBehaviour
{
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();

        Initialize();
    }

    #region Play Functions
    public void Play(string clipName, float volumeScale = 1f)
    {
        if (!clipIndexOf.ContainsKey(clipName)) return;
        audioSource.PlayOneShot(clips[clipIndexOf[clipName]], volumeScale);
    }

    public void Play(Sfx sfx, float volumeScale = 1f)
    {
        audioSource.PlayOneShot(clips[(int)sfx], volumeScale);
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
