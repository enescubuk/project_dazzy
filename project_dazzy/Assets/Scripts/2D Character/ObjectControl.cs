using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectControl : MonoBehaviour
{
    private Vector3 difference;
    private void OnMouseDown()
    {
        difference = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition-difference);
    }
}
