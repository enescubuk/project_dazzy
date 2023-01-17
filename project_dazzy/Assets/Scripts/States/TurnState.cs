using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnState : State
{
    [SerializeField] GameObject player;

    public RunState runState;

    public IdleState idleState;

    public JumpState jumpState;
    public override State RunCurrentState()
    {

        player.GetComponent<Animator>().SetBool("isRun",false);
        player.GetComponent<Animator>().SetBool("isTurn",true);
        
        //State Machine
        if(Input.GetAxisRaw("Horizontal") == 0)
        {
        return idleState;
        }
        else //if (Input.GetAxisRaw("Horizontal") != 0)
        {
        player.GetComponent<Animator>().SetBool("isRun",true);
        return runState;
        }

        
    }
}
