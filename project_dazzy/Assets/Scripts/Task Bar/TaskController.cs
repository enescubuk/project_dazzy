using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class TaskController : MonoBehaviour
{
    [Header("Task 1")]
    public Transform tast1Toggle;
    public Transform task1All;
    
    [Header("Task 2")]
    public Transform tast2Toggle;
    public Transform task2All;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            tast1Toggle.gameObject.SetActive(true);
            tast1Toggle.DOScale(new Vector2(1, 1), 1f);
            task1All.DOMoveX(task1All.transform.position.x + 600,1f).SetEase(Ease.InOutBack).SetDelay(2f);
            DOTween.PlayAll();
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            tast2Toggle.gameObject.SetActive(true);
            tast2Toggle.DOScale(new Vector2(1, 1), 1f);
            task2All.DOMoveX(task2All.transform.position.x + 600,1f).SetEase(Ease.InOutBack).SetDelay(2f);
            DOTween.PlayAll();
        }
    }
}
