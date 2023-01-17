using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{

    [SerializeField] GameObject player;

    public RunState runState;

    public JumpState jumpState;

    float preFace,last;
    // Start is called before the first frame update
    public override State RunCurrentState()
    {

        
        //State Machine
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            player.GetComponent<Animator>().SetBool("isRun",true);
            return runState;
        }
        if (Input.GetButtonDown("Jump"))
        {
            if (raycastController.current.groundCheck == true)
            {
                player.GetComponent<Animator>().SetTrigger("isJump");
                Debug.Log(31);
                return jumpState;  
            }
        }
        
            return this;
        

        
    }
}
