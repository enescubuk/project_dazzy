using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class desturationController : MonoBehaviour
{

    public GameObject remains;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            Instantiate(remains, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}