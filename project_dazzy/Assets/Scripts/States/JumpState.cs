using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState : State
{
    [SerializeField] Rigidbody player;

    [SerializeField] Animator animator;

    public RunState runState;

    public IdleState IdleState;

    [SerializeField] raycastController ray;
    public override State RunCurrentState()
    {
        //player.GetComponent<Rigidbody>().AddForce(new Vector3(0,450 *Time.deltaTime ,0));
        
        player.GetComponent<Rigidbody>().velocity = new Vector3(0,20,0);
        
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            return runState;
        }
        else return IdleState;
    }
}
