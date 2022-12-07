using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Game/Folder")]
public class folderSO : ScriptableObject
{
    public GameObject windowPrefab;
    public float clickCoolDown;
    public string[] foldersName = new string[5];
    public float clickRange;
}
