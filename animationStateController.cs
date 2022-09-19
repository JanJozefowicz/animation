using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{

    Animator animator;
    int isWalkingHash;
    int isRunningHash;

    void Start()
    {

        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");

    }


    void Update()
    {
        bool isrunning = animator.GetBool(isRunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");

        if(!isWalking && forwardPressed){

            animator.SetBool(isWalkingHash, true);

        }

        if(isWalking && !forwardPressed){

            animator.SetBool(isWalkingHash, false);
        }

        if(!isrunning && (forwardPressed && runPressed)){

            animator.SetBool(isRunningHash, true);

        }

        if(isrunning && (!forwardPressed || !runPressed)){

            animator.SetBool(isRunningHash, false);

        }
    }
}
