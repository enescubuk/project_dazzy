using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class UiController : MonoBehaviour
{
    public Transform startMenu;

    private bool onOffControl = false;

    public void StartButton()
    {
        if (onOffControl == false)
        {
            startMenu.DOMoveY(0.14f, 0.2f).SetEase(Ease.OutExpo);
            DOTween.PlayAll();
            onOffControl = true;
        }else
        {
            startMenu.DOMoveY(-3, 0.2f).SetEase(Ease.OutExpo);
            DOTween.PlayAll();
            onOffControl = false;
        }
    }
}
