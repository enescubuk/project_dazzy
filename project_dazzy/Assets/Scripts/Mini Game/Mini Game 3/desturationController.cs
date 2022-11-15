using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desturationController : MonoBehaviour
{

    public GameObject remains;
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(remains, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
