using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInput : MonoBehaviour
{
    [SerializeField]characterSO characterSO;
    public float mouseX, mouseY;
    public float moveX,moveY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouseInput();
        moveInput();
    }
    void mouseInput()
    {
        mouseX = Input.GetAxis("Mouse X")  * characterSO.mouseSensivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y")  * characterSO.mouseSensivity * Time.deltaTime;

    }

    void moveInput()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical") ;
    }



}
