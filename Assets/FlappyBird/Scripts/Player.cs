using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  Rigidbody2D rb;
  [SerializeField] float jumpAmount = 2f;
  int scoreCount = 0;

  private void Awake()
  {
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
      Jump();
    }
  }

  void Jump()
  {
    rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
  }

  private void OnCollisionEnter2D(Collision2D other)
  {
    if (other.gameObject.tag == "Pipe")
    {
      //Need to do game over here
      Debug.Log("Bird hit pipe");
      Destroy(this.gameObject);
    }
  }

  private void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Counter")
    {
      scoreCount++;
      Debug.Log(scoreCount);
    }
  }
}
