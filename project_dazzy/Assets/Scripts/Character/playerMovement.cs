using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField]characterSO characterSO;
    playerInput playerInput => GetComponent<playerInput>();
    groundChecking groundChecking => GetComponentInChildren<groundChecking>();
    public CharacterController controller => GetComponent<CharacterController>();
    public Vector3 velocity;
    void Update()
    {
        charaterMove();
        if (Input.GetButtonDown("Jump"))
        {
            
            //characterJump();
        }
    }
    void charaterMove()
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
        velocity.y += MathF.Sqrt(characterSO.jumpHeight * characterSO.gravity * Time.deltaTime);
       //MathF.Sqrt(velocity.y);
        GetComponentInChildren<animController>().jump();
        
        //StartCoroutine(waitOneSecond());
    }
    IEnumerator waitOneSecond()
    {
        yield return new WaitForSecondsRealtime(0.6f);
        velocity.y = characterSO.jumpHeight;
    }
}
