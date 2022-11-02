using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectObject : MonoBehaviour
{
    [SerializeField]characterSO characterSO;
    private string selectableTag = "Selectable";
    private Transform _selection;

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
            if (selection.CompareTag(selectableTag))
            {
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null )
                {
                    selectionRenderer.material = characterSO.selectMaterial;
                }
                _selection = selection;
            }
        }
    }
}
