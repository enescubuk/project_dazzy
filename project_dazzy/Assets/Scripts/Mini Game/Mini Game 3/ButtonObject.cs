using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

public class ButtonObject : MonoBehaviour
{
    public UnityEvent unityEvent = new UnityEvent();
    public Transform Arrow;
    public GameObject button;

    private void Start()
    {
        button = this.gameObject;
        Arrow.DOMoveY(Arrow.transform.position.y + 3f, 1f).SetLoops(-1, LoopType.Yoyo);
        DOTween.PlayAll();
    }

    private void Update()
    {
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray,out hit) && hit.collider.gameObject == gameObject)
            {
                unityEvent.Invoke();
            }
        }
    }
}
