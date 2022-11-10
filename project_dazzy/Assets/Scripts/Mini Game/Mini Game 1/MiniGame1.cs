using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGame1 : MonoBehaviour
{
    [SerializeField] private MiniGameSO miniGameSo;

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Movement();
    }

    
    private void Movement()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity = Vector3.up * miniGameSo.speed;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = Vector3.left * miniGameSo.speed;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.velocity = Vector3.down * miniGameSo.speed;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = Vector3.right * miniGameSo.speed;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector3.zero * miniGameSo.speed;
        }
        
    }
}
