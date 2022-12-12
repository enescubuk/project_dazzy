using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class folderName : MonoBehaviour
{
    [SerializeField]folderSO folderSO;
    private GameObject folderNameText => transform.GetChild(0).gameObject;

    void Start()
    {
        folderNameText.GetComponent<TextMeshPro>().text = folderSO.foldersName[Random.Range(0,folderSO.foldersName.Length)];
    }
    void Update()
    {
        transform.RotateAround(transform.position,new Vector3(0,1,0),100 * Time.deltaTime);
        folderNameText.transform.LookAt(GameObject.FindWithTag("Player").transform);
        transform.Rotate(new Vector3(0,180,0));
    }
}
