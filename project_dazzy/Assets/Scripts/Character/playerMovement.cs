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
        Vector3 move = transform.right * playerInput.moveX + transform.forward * playerInput.moveY ;
        controller.Move(move * characterSO.speed * Time.deltaTime * -1);
        velocity.y += characterSO.gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    void characterJump()
    {
        GetComponentInChildren<animController>().jump();
        StartCoroutine(waitOneSecond());
    }
    IEnumerator waitOneSecond()
    {
        yield return new WaitForSecondsRealtime(0.6f);
        velocity.y = Mathf.Sqrt(characterSO.jumpHeight * -2f * characterSO.gravity);
    }
}
