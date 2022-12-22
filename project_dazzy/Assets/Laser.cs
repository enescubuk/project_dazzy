using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    LineRenderer lineRenderer => GetComponent<LineRenderer>();

    void Start()
    {
            // çizgi rengini kırmızı olarak ayarlayın
        lineRenderer.startColor = Color.red;
        lineRenderer.endColor = Color.red;
    }


    void Update()
    {
    Vector3[] positions = CalculatePositions();

    // pozisyon değerlerini Line renderer öğesine atayın
    lineRenderer.SetPositions(positions);

    RaycastHit hit;

    if (Physics.Raycast(transform.position,Vector3.down,out hit))
    {
        if (hit.collider.gameObject.tag == "Player")
        {
            Destroy(hit.transform.gameObject);
        }
    }


    }
    Vector3[] CalculatePositions()
{
    
    // çizgi boyunca pozisyon değerlerini hesaplayın
    Vector3[] positions = new Vector3[2];
    positions[0] = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    positions[1] = new Vector3(transform.position.x, transform.position.y-20, transform.position.z);;
    return positions;
}
}
