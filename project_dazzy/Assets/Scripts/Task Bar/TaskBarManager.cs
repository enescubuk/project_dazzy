using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TaskBarManager : MonoBehaviour
{
    [SerializeField] private TaskBar taskBar = null;

    [SerializeField] private TextMeshProUGUI task1 = null;
    [SerializeField] private TextMeshProUGUI task2 = null;

    private void Start()
    {
        task1.text = taskBar.Task1;
        task2.text = taskBar.Task2;

    }
}
