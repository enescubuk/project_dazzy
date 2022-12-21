using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animController : MonoBehaviour
{
    private Animator animator => GetComponent<Animator>();
    Vector3 leftRot,rightRot;
    void Awake()
    {

        rightRot = transform.eulerAngles;
        leftRot = rightRot;
        leftRot.y -= 180f;
        
    }
    public void jump()
    {

        animator.SetTrigger("isJump");
        
    }
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            animator.SetBool("isRun",true);
            rotateLerping(leftRot,rightRot);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            animator.SetBool("isRun",true);
            rotateLerping(rightRot,leftRot);
        }
        else
        {
            animator.SetBool("isRun",false);
        }
    }

    private void rotateLerping(Vector3 firstRot, Vector3 nextRot)
    {
        transform.eulerAngles = nextRot;
    }

    public void dieEvent()
    {
        Destroy(this.gameObject.transform.parent.gameObject);
    } 
}
