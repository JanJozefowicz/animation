using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationBlendController : MonoBehaviour
{
      Animator animator;
    float velocity = 0.0f;
    public float acceleration = 0.1f;
    public float deceleration = 0.5f;
    int VelocityHash;


    void Start() {
        animator = GetComponent<Animator>();

        VelocityHash = Animator.StringToHash("Velocity Z");

    }

    void Update() {
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");


    if(forwardPressed && velocity < 1f){

        velocity += Time.deltaTime * acceleration;
    }

    if(!forwardPressed && velocity > 0.0f){

        velocity -= Time.deltaTime * deceleration;

    }

    if(!forwardPressed && velocity < 0.0f){
        velocity = 0.0f;
    }

        animator.SetFloat(VelocityHash, velocity);

    }
}
