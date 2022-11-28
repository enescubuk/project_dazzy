using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class desturationController : MonoBehaviour
{
    public GameObject remains;
    public List<GameObject> cube;
    private int count;

    private void Start()
    {
        count = 0;
    }
    

    public IEnumerator CubeCont()
    {
        for (int i = 0; i <= count; i++)
        {
            if (i != cube.Count)
            {
                Instantiate(remains, cube[count].transform.position, cube[count].transform.rotation);
                Destroy(cube[count]);
                yield return new WaitForSeconds(0.5f);
                count++;
            }
        }
    }

    public void CubeContButton()
    {
        StartCoroutine(CubeCont());
    }
}