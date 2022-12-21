using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{


/* [SerializeField]characterSO characterSO;
    playerInput playerInput => GetComponent<playerInput>();
    groundChecking groundChecking => GetComponentInChildren<groundChecking>();
    public CharacterController controller => GetComponent<CharacterController>();
    public Vector3 velocity;
*/
    public bool isJump;
    public float speed = 3;
    public float rotationSpeed = 90;

    public float gravity = -20f;

    public float jumpSpeed = 15;

    CharacterController characterController;
    public Vector3 moveVelocity;
    public Vector3 turnVelocity;

    public static playerMovement current;
    void Awake()
    {
        if (current != null && current != this)
        {
            Destroy(this);
        }
        else
        {
            current = this;
        }

        characterController = GetComponent<CharacterController>();
    }
    void Update()
    {
        var hinput = Input.GetAxis("Vertical");
        var vinput = Input.GetAxis("Horizontal");

    if (characterController.isGrounded)
    {
        moveVelocity = transform.right * speed * vinput;
        turnVelocity = transform.up * rotationSpeed * hinput;
        if (Input.GetButtonDown("Jump"))
        {
            
            GetComponentInChildren<animController>().jump();
            //
        }
        if (isJump)
        {
            moveVelocity.y = jumpSpeed;
        }
        
    }
    //Gravity
    moveVelocity.y += gravity * Time.deltaTime;
    characterController.Move(moveVelocity*  Time.deltaTime);
    transform.Rotate(turnVelocity * Time.deltaTime);
    }

    public void Jump(){


    }
/* void charaterMove()
    {
        Vector3 move = transform.right * playerInput.moveX;
        //controller.Move();
        velocity.y += characterSO.gravity * Time.deltaTime;
        //controller.Move(velocity * Time.deltaTime);

        Vector2 movement = new Vector2(move.x * characterSO.speed * Time.deltaTime * -1, velocity.y);
        controller.Move(movement);
    }

    void characterJump()
    {
        //velocity.y += MathF.Sqrt(characterSO.jumpHeight * characterSO.gravity * Time.deltaTime);
       //MathF.Sqrt(velocity.y);
        
        GetComponentInChildren<animController>().jump();
        velocity.y += 5;
        
       // StartCoroutine(waitOneSecond());
    }
    IEnumerator waitOneSecond()
    {
        yield return new WaitForSecondsRealtime(0.6f);
        velocity.y = characterSO.jumpHeight;
    }*/
}
