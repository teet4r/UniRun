using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class ButtonToggleInfo
{
    public ButtonToggleInfo(Sprite sprite, Color color)
    {
        this.sprite = sprite;
        this.color = color;
    }

    public Sprite sprite;
    public Color color;
}

[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Image))]
public abstract class ButtonToggle : MonoBehaviour
{
    void Awake()
    {
        image = GetComponent<Image>();

        #region Valid Check
        if (on == null || on.sprite == null)
            throw new Exception("On value is null.");
        if (off == null || off.sprite == null)
            throw new Exception("Off value is null.");
        #endregion
    }

    void Start()
    {
        Initialize();
    }

    public void Toggle()
    {
        isOn = !isOn;
        if (isOn)
            SetOn();
        else
            SetOff();
    }

    public void Toggle(bool on)
    {
        isOn = on;
        if (isOn)
            SetOn();
        else
            SetOff();
    }

    /// <summary>
    /// 초기화
    /// </summary>
    protected abstract void Initialize();

    /// <summary>
    /// 켜졌을 때 행동 정의
    /// </summary>
    protected abstract void SetOn();

    /// <summary>
    /// 꺼졌을 때 행동 정의
    /// </summary>
    protected abstract void SetOff();

    public bool isOn { get; protected set; }

    [SerializeField]
    protected ButtonToggleInfo on = new ButtonToggleInfo(null, Color.white);
    [SerializeField]
    protected ButtonToggleInfo off = new ButtonToggleInfo(null, Color.white);

    protected Image image;
}
