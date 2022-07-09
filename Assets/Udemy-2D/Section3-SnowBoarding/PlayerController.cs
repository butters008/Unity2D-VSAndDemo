using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Declare 
    Rigidbody2D rb2d;
    [SerializeField] float force = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
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
