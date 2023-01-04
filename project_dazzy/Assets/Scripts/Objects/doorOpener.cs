using System.Collections;
using UnityEngine;
using DG.Tweening;

public class doorOpener : MonoBehaviour
{
    bool isOpen;
    public GameObject door;

    void Start()
    {
        DOTween.Init();

        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cube" || other.tag == "Player")
        {
            
            isOpen = true;
            door.transform.DOMoveY(door.transform.position.y+20,0.5f);
            //transform.GetChild(1).Translate(new Vector3(0,-2,0));
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Cube" || other.tag  == "Player")
        {
            
            isOpen = false;
            door.transform.DOMoveY(door.transform.position.y-20,0.5f);
            //transform.GetChild(0).Translate(new Vector3(0,-12,0));
            //transform.GetChild(1).Translate(new Vector3(0,+2,0));
        }
    }
}
