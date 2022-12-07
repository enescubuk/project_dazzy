using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class folderOpener : MonoBehaviour
{
    public folderSO folderSO;
    selectObject selectObject => GetComponent<selectObject>();
    public Vector3 offset;

    private int clickCounter;
    private float lastClickTime,nextClickTime;

    public void isFolderOpen(Transform selection)
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (clickCounter == 0)
            {
                lastClickTime = Time.time;
                nextClickTime = lastClickTime +folderSO.clickCoolDown;
                clickCounter++;
            }
            else if (clickCounter == 1)
            {
                if (Time.time < nextClickTime && Vector3.Distance(transform.position,selection.position) <= folderSO.clickRange)
                {
                    windowOpen(selection);
                    clickCounter = 0;
                    Debug.Log("klasör açıldı");

                }
                else
                {
                    Debug.Log("klasör açılamdı");
                    clickCounter = 0;
                }
            }
        }
    }

    private void windowOpen(Transform folderPosition)
    {
        Destroy(folderPosition.gameObject);
        Instantiate(folderSO.windowPrefab,folderPosition.position + offset,Quaternion.identity);
    }
}