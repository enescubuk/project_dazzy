using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class closeButton : MonoBehaviour
{
    public UnityEvent unityEvent = new UnityEvent();
    private GameObject button;
    public void invoker()
    {
        unityEvent.Invoke();
        gameObject.transform.parent.gameObject.SetActive(false);
    }

    public void asd()
    {
        Debug.Log(31);
    }

}
