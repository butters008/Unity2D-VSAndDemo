using UnityEngine;
using UnityEngine.InputSystem;

namespace VS_MobileClone.Scripts
{
    public class VSPlayer : MonoBehaviour
    {
        // [SerializeField] float moveSpeed = 20f;
        // [SerializeField] float turnSpeed = 300f;
    
        void Start()
        {
        
        }

        void Update()
        {
            if (Touchscreen.current.primaryTouch.press.isPressed)
            {
                Debug.Log("Hello");
                // MoveCharacter();
            }

        }

        private void MoveCharacter()
        {
            // float steerAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
            // float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
            // transform.Rotate(0, 0, -turnSpeed * Time.deltaTime);
        
            // transform.Translate(0, moveSpeed * Time.deltaTime, 0);
            // Vector2 touchPosition = Touchscreen.current.primaryTouch.position.ReadValue();
            // Vector3 worldPosition = mainCamera.ScreenToWorldPoint(touchPosition);
            //
            // currentBallRigidBody.position = worldPosition;
            // currentBallRigidBody.isKinematic = true;
        }
    }
}
