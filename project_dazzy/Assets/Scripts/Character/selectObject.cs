using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectObject : MonoBehaviour
{
    [SerializeField]characterSO characterSO;
    private string selectableTag = "Selectable";
    private Transform _selection;
    public Material selectingMat;
    float lastPosX, lastPosZ;
    public Transform selection;
    scaleAlgoritm scaleAlgoritm => GetComponent<scaleAlgoritm>();
    Vector3 lastBoxPos;
    public Transform cubeA, cubeB, cubeC, cubeD;
    void Update()
    {
        if (_selection != null)
        {
            var seelctionRenderer = _selection.GetComponent<Renderer>();
            seelctionRenderer.material = characterSO.defaultMaterial;
            _selection = null;
        }
        var ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width/2f, Screen.height/2f, 0f));
        RaycastHit hit;
        if (Physics.Raycast(ray,out hit))
        {
            selection = hit.transform;
            if (selection.CompareTag(selectableTag))
            {
                
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (Input.GetMouseButtonDown(0))
                {
                    lastPosX = ray.direction.x;
                    lastPosZ = ray.direction.z;
                    lastBoxPos = selection.position;
                }
                if (Input.GetMouseButton(0))
                {
                    
                    float newposX = (ray.direction.x - lastPosX)/70;
                    float newposZ = (ray.direction.z - lastPosZ)/70;
                    
                    detectName(newposX,newposZ,selectionRenderer);
                    selectionRenderer.material = selectingMat;
                }
                else if (selectionRenderer != null )
                {
                    
                    selectionRenderer.material = characterSO.selectMaterial;
                }

                if (Input.GetMouseButtonUp(0))
                {
                    Debug.Log(selection.name + " " + Vector3.Distance(selection.position,lastBoxPos));
                    changeScale(selection ,Vector3.Distance(selection.position,lastBoxPos));
                }
                
                _selection = selection;
            }
        }
    }

    private void changeScale(Transform selection, float distance)
    {
        //if (selection.name == "A")
        //{
        //    selection.localScale = new Vector3
        //    (selection.localScale.x,
        //        selection.localScale.y,
        //            selection.localScale.z);
        //}
        //else if (selection.name == "B")
        //{
        //    selection.localScale = new Vector3
        //    (selection.localScale.x,
        //        selection.localScale.y,
        //            selection.localScale.z);
        //}
        //else if (selection.name == "C")
        //{
        //    selection.localScale = new Vector3
        //    (selection.localScale.x,
        //        selection.localScale.y,
        //            selection.localScale.z);
        //}
        //else if (selection.name == "D")
        //{
        //    selection.localScale = new Vector3
        //    (selection.localScale.x,
        //        selection.localScale.y,
        //            selection.localScale.z);
        //}

        if (selection.name == "A")
        {
            cubeB.localScale = new Vector3
            (cubeB.localScale.x + distance,
                cubeB.localScale.y,
                    cubeB.localScale.z);
            
            cubeB.position = new Vector3
            (cubeB.position.x,
                cubeB.position.y,
                    cubeB.position.z + distance/2);

            cubeD.localScale = new Vector3
            (cubeD.localScale.x + distance,
                cubeD.localScale.y,
                    cubeD.localScale.z);
            
            cubeD.position = new Vector3
            (cubeD.position.x,
                cubeD.position.y,
                    cubeD.position.z + distance/2);
        }
        else if (selection.name == "B")
        {
            cubeC.localScale = new Vector3
            (cubeC.localScale.x + distance,
                cubeC.localScale.y,
                    cubeC.localScale.z);
            
            cubeC.position = new Vector3
            (cubeC.position.x - distance/2,
                cubeC.position.y,
                    cubeC.position.z);

            cubeA.localScale = new Vector3
            (cubeA.localScale.x + distance,
                cubeA.localScale.y,
                    cubeA.localScale.z);
            
            cubeA.position = new Vector3
            (cubeA.position.x - distance/2,
                cubeA.position.y,
                    cubeA.position.z);
        }
        else if (selection.name == "C")
        {
            cubeB.localScale = new Vector3
            (cubeB.localScale.x + distance,
                cubeB.localScale.y,
                    cubeB.localScale.z);
            
            cubeB.position = new Vector3
            (cubeB.position.x,
                cubeB.position.y,
                    cubeB.position.z - distance/2);

            cubeD.localScale = new Vector3
            (cubeD.localScale.x + distance,
                cubeD.localScale.y,
                    cubeD.localScale.z);
            
            cubeD.position = new Vector3
            (cubeD.position.x,
                cubeD.position.y,
                    cubeD.position.z - distance/2);
        }
        else if (selection.name == "D")
        {
            cubeC.localScale = new Vector3
            (cubeC.localScale.x + distance,
                cubeC.localScale.y,
                    cubeC.localScale.z);
            
            cubeC.position = new Vector3
            (cubeC.position.x + distance/2,
                cubeC.position.y,
                    cubeC.position.z);

            cubeA.localScale = new Vector3
            (cubeA.localScale.x + distance,
                cubeA.localScale.y,
                    cubeA.localScale.z);
            
            cubeA.position = new Vector3
            (cubeA.position.x + distance/2,
                cubeA.position.y,
                    cubeA.position.z);
        }
    }

    void detectName(float newposX,float newposZ,Renderer selectionRenderer)
    {
        if (selection.name == "A")
        {
            selectionRenderer.gameObject.transform.position = 
            new Vector3(selectionRenderer.gameObject.transform.position.x,
            selectionRenderer.gameObject.transform.position.y,
            selectionRenderer.gameObject.transform.position.z + newposZ);
        }
        else if (selection.name == "B")
        {
            selectionRenderer.gameObject.transform.position = 
            new Vector3(selectionRenderer.gameObject.transform.position.x + newposX,
            selectionRenderer.gameObject.transform.position.y,
            selectionRenderer.gameObject.transform.position.z);
        }
        else if (selection.name == "C")
        {
            selectionRenderer.gameObject.transform.position = 
            new Vector3(selectionRenderer.gameObject.transform.position.x,
            selectionRenderer.gameObject.transform.position.y,
            selectionRenderer.gameObject.transform.position.z+ newposZ);
        }
        else if (selection.name == "D")
        {
            selectionRenderer.gameObject.transform.position = 
            new Vector3(selectionRenderer.gameObject.transform.position.x + newposX,
            selectionRenderer.gameObject.transform.position.y,
            selectionRenderer.gameObject.transform.position.z);
        }
        
    }


}
