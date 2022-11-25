using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JumpButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        target.Jump();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        target.JumpDecelerate();
    }

    public Player target;
}
