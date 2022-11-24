using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectObject : MonoBehaviour
{
    [SerializeField]objectSO objectSO;
    private windowController windowController;
    folderMovement folderMovement;
    private folderOpener folderOpener => GetComponent<folderOpener>();
    private Transform selection;
    private Renderer selectionRenderer;


    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width/2f, Screen.height/2f, 0f));
        RaycastHit hit;
        if (Physics.Raycast(ray,out hit))
        {
            if (selection != null && selection.CompareTag(objectSO.selectableTag))
            {
                selectionRenderer = selection.GetComponent<Renderer>();
                if (windowController.moving != true)
                {
                    selectionRenderer.material = objectSO.defaultMaterial;
                }
                selection = null;
            }
            selection = hit.transform;
            if (selection.CompareTag(objectSO.selectableTag))
            {
                windowController = selection.GetComponentInParent<windowController>();
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (Input.GetMouseButtonDown(0))
                {
                    selectionRenderer.material = objectSO.selectingObject;
                    windowController.firstClick(selection,ray);
                }
                if (Input.GetMouseButton(0))
                {
                    
                }
                else if (selectionRenderer != null && windowController.moving == false)
                {
                    selectionRenderer.material = objectSO.onObject;
                }
                
            }
            if (selection.name.Contains("Folder"))
            {
                folderOpener.isFolderOpen(selection);
            }
        }
        if (windowController != null)
        {
            if (windowController.moving == true)
            {
                windowController.calcMove(ray);
                if (Input.GetMouseButtonUp(0))
                {   
                    windowController.clickDone();
                    selectionRenderer.material = objectSO.defaultMaterial;
                    windowController.moving = false;
                }
            }
        }
    }
}
