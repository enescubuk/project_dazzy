using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkScene : MonoBehaviour
{
    public Material[] darkMaterial;

    public GameObject groundParent;

    private void Start()
    {
        Dark();
        
    }

    private void Dark()
    {
        Camera.main.backgroundColor =  Color.black;

        foreach (Transform item in groundParent.transform)
        {
            item.GetComponent<MeshRenderer>().materials = darkMaterial;
        }
    }
}
