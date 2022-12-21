using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundChecking : MonoBehaviour
{
    playerMovement playerMovement => GetComponentInParent<playerMovement>();
    public bool groundCheck;
    void OnTriggerEnter(Collider other)
    {
        groundCheck = true;
       // playerMovement.velocity.y = 0;
    }
    void OnTriggerExit(Collider other)
    {
        groundCheck = false;
    }
}
