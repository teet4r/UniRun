using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmButton : ButtonToggle
{
    protected override void Initialize()
    {
        isOn = DBManager.bgmOn;
        Toggle(isOn);
    }

    protected override void SetOn()
    {
        SoundManager.instance.bgmAudio.mute = !isOn;
        DBManager.bgmOn = isOn;
        image.sprite = on.sprite;
        image.color = on.color;
    }

    protected override void SetOff()
    {
        SoundManager.instance.bgmAudio.mute = !isOn;
        DBManager.bgmOn = isOn;
        image.sprite = off.sprite;
        image.color = off.color;
    }

}
