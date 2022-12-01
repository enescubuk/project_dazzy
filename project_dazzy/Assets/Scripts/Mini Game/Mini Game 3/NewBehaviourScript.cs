using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform Arrow;

    private void Awake()
    {
        Arrow.DOMoveY(5f, 1f).SetLoops(-1, LoopType.Yoyo);
        DOTween.PlayAll();
    }

    void Update()
    {
        
        
    }
}
