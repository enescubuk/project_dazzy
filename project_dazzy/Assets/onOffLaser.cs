using System.Collections;
using UnityEngine;

public class onOffLaser : MonoBehaviour
{
    GameObject laserStick => transform.GetChild(0).gameObject;
    private float repeatTime = 2f;

    void stickPassive()
    {
        laserStick.SetActive(false);
        Invoke("stickActive", repeatTime);
    }

    void stickActive()
    {
        laserStick.SetActive(true);
        Invoke("stickPassive", repeatTime);
    }

    void Start()
    {
        stickActive();
    }
}
