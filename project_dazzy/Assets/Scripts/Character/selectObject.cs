using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectObject : MonoBehaviour
{
    [SerializeField]characterSO characterSO;
    private string selectableTag = "Selectable";
    private Transform _selection;
    public Material selectingMat;
    private Vector3 naber;
    float lastPosx;
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
            var selection = hit.transform;
            Debug.Log(ray);
            if (selection.CompareTag(selectableTag))
            {
                
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (Input.GetMouseButtonDown(0))
                {
                    lastPosx = ray.direction.x;
                }
                if (Input.GetMouseButton(0))
                {
                    
                    float newpos = (ray.direction.x - lastPosx)/70;
                    selectionRenderer.gameObject.transform.position = new Vector3(selectionRenderer.gameObject.transform.position.x + newpos,selectionRenderer.gameObject.transform.position.y,selectionRenderer.gameObject.transform.position.z);
                    selectionRenderer.material = selectingMat;
                }
                else if (selectionRenderer != null )
                {
                    
                    selectionRenderer.material = characterSO.selectMaterial;
                }
                
                _selection = selection;
            }
        }
    }
}
