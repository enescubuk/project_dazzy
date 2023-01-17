using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class RunState : State
{
    [SerializeField] GameObject player;

    [SerializeField] Animator anim;
    public IdleState idleState;

    public TurnState turnState;
    public JumpState jumpState;

    float preFace,last;
    Vector3 rightRot => player.transform.eulerAngles;
    public override State RunCurrentState()
    {
        Debug.Log(Input.GetAxisRaw("Horizontal"));

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            player.transform.Translate(Vector3.left * 10f* Time.deltaTime);
            player.transform.eulerAngles = new Vector3(rightRot.x,0,rightRot.z);
            
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            
            player.transform.Translate(Vector3.left* 10f * Time.deltaTime);
            player.transform.eulerAngles = new Vector3(rightRot.x,180,rightRot.z);    
        }
        if(Input.GetAxisRaw("Horizontal") == 0 && preFace == last)
        {
            anim.SetBool("isRun",false);
            return idleState;
        }
        if (Input.GetButtonDown("Jump"))
        {
            if (raycastController.current.groundCheck == true)
        {
            anim.SetTrigger("isJump");
            Debug.Log(31);
            return jumpState;  
        }
        }

        return this;
    }
}
