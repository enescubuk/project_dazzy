    using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windowController : MonoBehaviour
{ 
    [SerializeField]objectSO objectSO;
    changeScale changeScale => GetComponent<changeScale>();
    Vector3 firstPosMouse,firstPosObject,lastPosObject;
    private Transform _selection;
    Vector3 newPos;
    public bool moving = false;
    public Transform[] cubes = new Transform[5];
    private int whichEdge;
    public void calcMove(Ray ray)
    {
        newPos.x = (ray.direction.x - firstPosMouse.x)/objectSO.objectDragSpeed;
        newPos.y = (ray.direction.y - firstPosMouse.y)/objectSO.objectDragSpeed;
        newPos.z = 0;
        clicking();
    }
    public void firstClick(Transform selection , Ray ray)
    {
        _selection = selection;
        firstPosObject = selection.position;
        moving = true;
        firstPosMouse = ray.direction;
        
        if (_selection.name.Contains("Corner"))
        {
            if (_selection.name.Contains("AC"))
            {
                whichEdge = 0;
            }
            else
            {
                whichEdge = 1;
            }
        }
    }
    public void clicking()
    {
        if (_selection.name.Contains("Corner"))
        {
            cornerMovement();
        }
        else if (_selection.name.Contains("C Taskbar"))
        {
            taskbarMovement();
        }
        else if (_selection.name == "E Taskbar")
        {
            downEdgeMovement();
        }
        else if (_selection.name.Contains("Edge"))
        {
            edgeMovement();
        }
    }

    private void folderMovement()
    {
        Vector3 lastPos = _selection.position;
        lastPos.x += newPos.x;
        lastPos.y += newPos.y;
        _selection.position = lastPos;
        _selection.position += newPos;
    }

    private void edgeMovement()
    {
        Vector3 lastPos = _selection.position;
        lastPos.x += newPos.x;
        _selection.position = lastPos;
    }
    void downEdgeMovement()
    {
        Vector3 lastPos = _selection.position;
        lastPos.y += newPos.y;
        _selection.position = lastPos;
    }
    private void taskbarMovement()
    {
        _selection.transform.parent.position += newPos;
    }

    private void cornerMovement()
    {
        Vector3 lastPos = _selection.position;
        lastPos.x += newPos.x;
        lastPos.y += newPos.y;
        _selection.position = lastPos;
        cubes[2].transform.position += newPos;
    }

    public void clickDone()
    {
        lastPosObject = _selection.position;
        changeScale.detectDistance(lastPosObject,firstPosObject, _selection.gameObject);
    }

}
