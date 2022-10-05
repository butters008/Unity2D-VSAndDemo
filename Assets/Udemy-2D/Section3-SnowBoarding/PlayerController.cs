using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Declare 
    Rigidbody2D rb2d;
    [SerializeField] float force = 0;
    SurfaceEffector2D surfaceEffector2D;
    [SerializeField] float boostSpeed = 20.0f;
    [SerializeField] float baseSpeed = 30.0f;
    private bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D =  FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove){
            RotatePlayer();
            RespondToBoost();
        }
    }

    public void disableControls(){
        Debug.Log("Function called!");
        canMove = false;
    }

  private void RespondToBoost()
  {
    //if we push up, then speed up
    if (Input.GetKey(KeyCode.UpArrow)){
        surfaceEffector2D.speed = boostSpeed;
    }
    else {
        surfaceEffector2D.speed = baseSpeed;
    }
  }

  void RotatePlayer(){
        if(Input.GetKey(KeyCode.LeftArrow)){
            RotationForce(force);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            RotationForce(-force);
        }
    }

    void RotationForce(float force){
        rb2d.AddTorque(force);
    }
}
