using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBManager
{
    public static int bestScore
    {
        get
        {
            if (!PlayerPrefs.HasKey(PlayerPrefsKey.BEST_SCORE))
                PlayerPrefs.SetInt(PlayerPrefsKey.BEST_SCORE, 0);
            return PlayerPrefs.GetInt(PlayerPrefsKey.BEST_SCORE);
        }
        set { PlayerPrefs.SetInt(PlayerPrefsKey.BEST_SCORE, value); }
    }

    public static bool bgmOn
    {
        get
        {
            if (!PlayerPrefs.HasKey(PlayerPrefsKey.BGM_ON))
                PlayerPrefs.SetInt(PlayerPrefsKey.BGM_ON, 1);
            return PlayerPrefs.GetInt(PlayerPrefsKey.BGM_ON) == 1;
        }
        set { PlayerPrefs.SetInt(PlayerPrefsKey.BGM_ON, value ? 1 : -1); }
    }

    public static bool sfxOn
    {
        get
        {
            if (!PlayerPrefs.HasKey(PlayerPrefsKey.SFX_ON))
                PlayerPrefs.SetInt(PlayerPrefsKey.SFX_ON, 2);
            return PlayerPrefs.GetInt(PlayerPrefsKey.SFX_ON) == 2;
        }
        set { PlayerPrefs.SetInt(PlayerPrefsKey.SFX_ON, value ? 2 : -2); }
    }
}
