using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.SceneManagement;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch; //Mulit-Touch code

public class BallHandler : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private Rigidbody2D pivot;
    [SerializeField] private float timeDelay;
    [SerializeField] private float respawnDelay;
    
    private Rigidbody2D currentBallRigidBody;
    private SpringJoint2D currentBallSpringJoint;
    private Camera mainCamera;
    private bool isDragging; 
    
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        RespawnBall();
    }

    //Mulit-Touch code
    private void OnEnable()
    {
        EnhancedTouchSupport.Enable();
    }

    //Mulit-Touch code
    private void OnDisable()
    {
        EnhancedTouchSupport.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentBallRigidBody == null)
        {
            return;
        }

       // if (!Touchscreen.current.primaryTouch.press.isPressed)
       //Mulit-Touch code
       if(Touch.activeTouches.Count == 0 )
        {
            if (isDragging)
            {
                LaunchBall();
            }

            isDragging = false;

            return;
        }

        isDragging = true;

        //Mulit-Touch code
        Vector2 touchPosition = new Vector2();
        
        //Mulit-Touch code
        foreach (Touch touch in Touch.activeTouches)
        {
            touchPosition += touch.screenPosition;
        }

        //Mulit-Touch code
        touchPosition /= Touch.activeTouches.Count;
        
//        Vector2 touchPosition = Touchscreen.current.primaryTouch.position.ReadValue();
        Vector3 worldPosition = mainCamera.ScreenToWorldPoint(touchPosition);

        
        
        currentBallRigidBody.position = worldPosition;
        currentBallRigidBody.isKinematic = true;

    }

    private void LaunchBall()
    {
        currentBallRigidBody.isKinematic = false;
        currentBallRigidBody = null;
        
        Invoke(nameof(DetachBall), timeDelay);
    }

    private void DetachBall()
    {
        currentBallSpringJoint.enabled = false;
        currentBallSpringJoint = null;
        Invoke(nameof(RespawnBall), respawnDelay);
    }

    private void RespawnBall()
    {
        // Quaternion.identity default rotation
        GameObject ballInstance = Instantiate(ballPrefab, pivot.position, Quaternion.identity);
        currentBallRigidBody = ballInstance.GetComponent<Rigidbody2D>();
        currentBallSpringJoint = ballInstance.GetComponent<SpringJoint2D>();

        currentBallSpringJoint.connectedBody = pivot;
    }
    
    public void RestartLevel()
    {
        SceneManager.LoadScene("Ball Launcher Game Demo"); 
    }
}
