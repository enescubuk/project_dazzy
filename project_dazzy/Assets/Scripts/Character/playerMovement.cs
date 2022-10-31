using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    playerInput playerInput => GetComponent<playerInput>();
    public CharacterController controller => GetComponent<CharacterController>() ;
    public float speed = 12f;
    public float gravity = -9.81f;
    

    Vector3 velocity;


    void Start()
    {
        
    }
    void Update()
    {
        charaterMove();
        characterJump();
    }
    void charaterMove()
    {
        Vector3 move = transform.right * playerInput.moveX + transform.forward * playerInput.moveY;
        controller.Move(move * speed * Time.deltaTime);
    }

    void characterJump()
    {
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
