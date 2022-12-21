using System.Collections;
using UnityEngine;

public class raycastController : MonoBehaviour
{
    public float distance;
    private LayerMask targetLayer;
    public bool draggable;
    public GameObject cube;
    Vector3 betweenDistance;
    void Start()
    {
        targetLayer = LayerMask.GetMask("Raycastable");
    }

    void Update()
    {
        RaycastHit hit;
        Debug.DrawLine(transform.position + transform.right * distance,transform.position + transform.right * distance * -1, Color.green);
        if (Physics.Raycast(this.transform.position,transform.TransformDirection(Vector3.right),out hit,distance,targetLayer) || Physics.Raycast(this.transform.position,transform.TransformDirection(Vector3.left),out hit,distance,targetLayer))
        {
            if (hit.collider.tag == "Cube")
            {
                dragObject(hit.collider.transform);
            }
        }

        if (draggable == true)
        {
            Vector3 lastBoxPos = cube.transform.position;
            lastBoxPos.x = transform.position.x - betweenDistance.x;
            cube.transform.position = lastBoxPos;
        }
    }
    void dragObject(Transform companionCube)
    {
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            cube = companionCube.gameObject;
            float xDistance = cube.transform.position.x - transform.position.x;
            if (xDistance <= 4 && xDistance >= -4)
            {
                if (xDistance < 0)
                {
                    cube.transform.position = new Vector3(transform.position.x - 4.09f,cube.transform.position.y,cube.transform.position.z);
                }
                else
                {
                    cube.transform.position = new Vector3(transform.position.x + 4.09f,cube.transform.position.y,cube.transform.position.z);
                }

            }
            else
            {
            }
            draggable = true;
            betweenDistance = transform.position - cube.transform.position;
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            draggable = false;
            cube = null;
        }
    }
}
