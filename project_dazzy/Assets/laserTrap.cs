using System.Collections;
using System;
using UnityEngine;
using UnityEngine.Events;

public class laserTrap : MonoBehaviour
{
    public UnityEvent dieEvent;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            dieEvent.Invoke();
        }
    }
}
