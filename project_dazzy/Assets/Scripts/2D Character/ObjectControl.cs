using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectControl : MonoBehaviour
{
    private Vector3 difference;
    private float zPosition;

    private void Start()
    {
        zPosition = transform.position.z;
    }

    private void OnMouseDown()
    {
        difference = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition-difference);
        var transformPosition = transform.position;
        transformPosition.z = zPosition;

    }
}
