using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  Rigidbody2D rb;
  [SerializeField] float jumpAmount = 2f;
    // Start is called before the first frame update
    private void Awake() {
      rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
      Debug.Log("Hello");
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown("space"))
      {
        print("space key was pressed");
        Jump();
      }
    }

    void Jump(){
      rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
    }
}
