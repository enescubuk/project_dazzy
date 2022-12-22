using System.Collections;
using UnityEngine;

public class virusMoveController : MonoBehaviour
{
    private float speed = 5f;

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponentInChildren<animController>().dieEvent();
        }
    }
}
