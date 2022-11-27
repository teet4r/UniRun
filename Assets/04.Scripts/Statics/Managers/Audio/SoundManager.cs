using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    void Awake()
    {
        #region Make Singleton
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
        #endregion
    }

    public static SoundManager instance = null;

    public BgmAudio bgmAudio;
    public SfxAudio sfxAudio;
}
