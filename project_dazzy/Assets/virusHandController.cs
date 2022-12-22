using System.Collections;
using UnityEngine;

public class virusHandController : MonoBehaviour
{
    private float repeatTime = 0.5f;

    Vector3 newPosHand;
    void Start()
    {
        newPosHand = transform.position;
        InvokeRepeating("newPos",1f,repeatTime);
    }
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position,newPosHand,0.05f);
        
    }
    void newPos()
    {
        newPosHand.x = transform.parent.position.x;
        newPosHand.x = Random.Range(newPosHand.x-10,newPosHand.x-15);
    }
}
