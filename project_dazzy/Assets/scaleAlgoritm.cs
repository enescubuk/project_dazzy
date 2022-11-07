using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleAlgoritm : MonoBehaviour
{
    selectObject selectObject=> GetComponent<selectObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (selectObject.gameObject.tag == "Selectable")
        {
            Debug.Log(selectObject.selection.gameObject.name);
        }
    }
}
