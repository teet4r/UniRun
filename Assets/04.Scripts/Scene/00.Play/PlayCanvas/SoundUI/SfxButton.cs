using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxButton : ButtonToggle
{
    protected override void Initialize()
    {
        isOn = DBManager.sfxOn;
        Toggle(isOn);
    }

    protected override void SetOn()
    {
        SoundManager.instance.sfxAudio.mute = !isOn;
        DBManager.sfxOn = isOn;
        image.sprite = on.sprite;
        image.color = on.color;
    }

    protected override void SetOff()
    {
        SoundManager.instance.sfxAudio.mute = !isOn;
        DBManager.sfxOn = isOn;
        image.sprite = off.sprite;
        image.color = off.color;
    }
}
