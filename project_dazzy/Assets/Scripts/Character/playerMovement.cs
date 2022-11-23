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
            characterJump();
        }
    }
    void charaterMove()
    {
        Vector3 move = transform.right * playerInput.moveX + transform.forward * playerInput.moveY;
        controller.Move(move * characterSO.speed * Time.deltaTime);
        velocity.y += characterSO.gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    void characterJump()
    {
        velocity.y = Mathf.Sqrt(characterSO.jumpHeight * -2f * characterSO.gravity);
    }
}
