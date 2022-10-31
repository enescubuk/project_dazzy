using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook : MonoBehaviour
{
    public playerInput playerInput => GetComponentInParent<playerInput>();
    float xRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        characterRotation();
    }

    void characterRotation()
    {
        xRotation -= playerInput.mouseY;
        xRotation = Mathf.Clamp(xRotation,-90f,90f);

        transform.localRotation = Quaternion.Euler(xRotation,0,0f);

        transform.parent.Rotate(Vector3.up * playerInput.mouseX);
    }

}
