using System.Collections;
using UnityEngine;

public class doorOpener : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.parent.tag == "Player" || other.tag == "Cube")
        {
            transform.GetChild(0).Translate(new Vector3(0,12,0));
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.transform.parent.tag == "Player" || other.tag == "Cube")
        {
            transform.GetChild(0).Translate(new Vector3(0,-12,0));
        }
    }
}
