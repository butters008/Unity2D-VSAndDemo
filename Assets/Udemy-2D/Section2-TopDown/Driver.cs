using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    //Declare vars
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float turnSpeed = 300f;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is a dumb");        
    }

    // Update is called once per frame
    void Update()
    {
        // RotateContinously();
        SteerCar();
    }

    private void RotateContinously()
    {
        transform.Rotate(0, 0, turnSpeed);
        transform.Translate(0, moveSpeed, 0);

    }

    private void SteerCar(){
        float steerAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
        
    }
}
