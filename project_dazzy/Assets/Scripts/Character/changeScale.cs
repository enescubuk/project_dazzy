using System;
using UnityEngine;

public class changeScale : MonoBehaviour 
{
    windowController windowController => GetComponent<windowController>();
    private Transform selection;
    Vector3 distance;
    public Transform[] corners = new Transform[2];
    public Vector3 cornerOffset1,cornerOffset2;
    public void detectDistance(Vector3 firstPos , Vector3 lastPos, GameObject objectGenre)
    {
        distance = lastPos - firstPos;
        selection = objectGenre.transform;
        switch (selection.name)
        {
            case "A Edge":
                aEdge();
                    break;
            
            case "B Edge":
                bEdge();
                    break;
            
            case "AC Corner":
                cTaskbar();
                Debug.Log(31313);
                    break;

            case "CB Corner":
                cbTaskbar();
                Debug.Log(621515125);
                    break;
        }

        Debug.Log(selection.name);
    }

    

    public void calcCornerOffset()
    {
        cornerOffset1 = corners[0].position - selection.position;
        cornerOffset2 = corners[1].position - selection.position;
    }
    private void aEdge()
    {
        for (int i = 2; i <= 4; i++)
        {
            windowController.cubes[i].localScale -= distance;
            windowController.cubes[i].position -= distance/2;
        }
        Vector3 asd = corners[0].position;
        asd.x -= distance.x;
        corners[0].position = asd;
    }

    

    private void bEdge()
    {
        for (int i = 2; i <= 4; i++)
        {
            windowController.cubes[i].localScale += distance;
            windowController.cubes[i].position -= distance/2;
        }
        Vector3 asd = corners[1].position;
        asd.x -= distance.x;
        corners[1].position = asd;
    }

    private void cTaskbar()
    {
        windowController.cubes[0].localScale = new Vector3(windowController.cubes[0].localScale.x,windowController.cubes[0].localScale.y - distance.y,windowController.cubes[0].localScale.z);
        windowController.cubes[1].localScale = new Vector3(windowController.cubes[1].localScale.x,windowController.cubes[1].localScale.y - distance.y,windowController.cubes[1].localScale.z);
        windowController.cubes[3].localScale = new Vector3(windowController.cubes[3].localScale.x,windowController.cubes[3].localScale.y - distance.y,windowController.cubes[3].localScale.z);

        windowController.cubes[0].transform.position = new Vector3(windowController.cubes[0].transform.position.x,windowController.cubes[0].transform.position.y - distance.y / 2,windowController.cubes[0].transform.position.z);
        windowController.cubes[1].transform.position = new Vector3(windowController.cubes[1].transform.position.x,windowController.cubes[1].transform.position.y - distance.y / 2,windowController.cubes[1].transform.position.z);
        windowController.cubes[3].transform.position = new Vector3(windowController.cubes[3].transform.position.x,windowController.cubes[3].transform.position.y - distance.y / 2,windowController.cubes[3].transform.position.z);
    
    
    
        for (int i = 2; i <= 4; i++)
        {
            Vector3 lastScale = windowController.cubes[i].localScale;
            lastScale.x-= distance.x;
            windowController.cubes[i].localScale = lastScale;
            Debug.Log(distance);
        }

        windowController.cubes[0].transform.position = new Vector3(windowController.cubes[0].transform.position.x - distance.x,windowController.cubes[0].transform.position.y,windowController.cubes[0].transform.position.z);
        windowController.cubes[2].transform.position = new Vector3(windowController.cubes[2].transform.position.x + distance.x/2,windowController.cubes[2].transform.position.y,windowController.cubes[2].transform.position.z);
        windowController.cubes[3].transform.position = new Vector3(windowController.cubes[3].transform.position.x - distance.x/2,windowController.cubes[3].transform.position.y,windowController.cubes[3].transform.position.z);
        windowController.cubes[4].transform.position = new Vector3(windowController.cubes[4].transform.position.x - distance.x/2,windowController.cubes[4].transform.position.y,windowController.cubes[4].transform.position.z);

        corners[1].transform.position = new Vector3(corners[1].transform.position.x,corners[1].transform.position.y - distance.y,corners[1].transform.position.z);
    }
    private void cbTaskbar()
    {
        windowController.cubes[0].localScale = new Vector3(windowController.cubes[0].localScale.x,windowController.cubes[0].localScale.y - distance.y,windowController.cubes[0].localScale.z);
        windowController.cubes[1].localScale = new Vector3(windowController.cubes[1].localScale.x,windowController.cubes[1].localScale.y - distance.y,windowController.cubes[1].localScale.z);
        windowController.cubes[3].localScale = new Vector3(windowController.cubes[3].localScale.x,windowController.cubes[3].localScale.y - distance.y,windowController.cubes[3].localScale.z);

        windowController.cubes[0].transform.position = new Vector3(windowController.cubes[0].transform.position.x,windowController.cubes[0].transform.position.y - distance.y / 2,windowController.cubes[0].transform.position.z);
        windowController.cubes[1].transform.position = new Vector3(windowController.cubes[1].transform.position.x,windowController.cubes[1].transform.position.y - distance.y / 2,windowController.cubes[1].transform.position.z);
        windowController.cubes[3].transform.position = new Vector3(windowController.cubes[3].transform.position.x,windowController.cubes[3].transform.position.y - distance.y / 2,windowController.cubes[3].transform.position.z);
    
    
    
        for (int i = 2; i <= 4; i++)
        {
            Vector3 lastScale = windowController.cubes[i].localScale;
            lastScale.x+= distance.x;
            windowController.cubes[i].localScale = lastScale;
            Debug.Log(distance);
        }

        windowController.cubes[1].transform.position = new Vector3(windowController.cubes[1].transform.position.x - distance.x,windowController.cubes[1].transform.position.y,windowController.cubes[1].transform.position.z);
        windowController.cubes[2].transform.position = new Vector3(windowController.cubes[2].transform.position.x + distance.x/2,windowController.cubes[2].transform.position.y,windowController.cubes[2].transform.position.z);
        windowController.cubes[3].transform.position = new Vector3(windowController.cubes[3].transform.position.x - distance.x/2,windowController.cubes[3].transform.position.y,windowController.cubes[3].transform.position.z);
        windowController.cubes[4].transform.position = new Vector3(windowController.cubes[4].transform.position.x - distance.x/2,windowController.cubes[4].transform.position.y,windowController.cubes[4].transform.position.z);
        corners[0].transform.position = new Vector3(corners[0].transform.position.x,corners[0].transform.position.y - distance.y,corners[0].transform.position.z);
    }
}