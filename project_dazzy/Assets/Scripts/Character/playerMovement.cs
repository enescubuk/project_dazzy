using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField]characterSO characterSO;
    playerInput playerInput => GetComponent<playerInput>();
    public CharacterController controller => GetComponent<CharacterController>();
    Vector3 velocity;
    void Update()
    {
        charaterMove();
        characterJump();
    }
    void charaterMove()
    {
        Vector3 move = transform.right * playerInput.moveX + transform.forward * playerInput.moveY;
        controller.Move(move * characterSO.speed * Time.deltaTime);
    }

    void characterJump()
    {
        
        velocity.y += characterSO.gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
