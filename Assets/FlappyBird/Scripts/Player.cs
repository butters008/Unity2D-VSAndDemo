using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
  Rigidbody2D rb;
  [SerializeField] float jumpAmount = 2f;
  public int scoreCount = 0;
  [SerializeField] TextMeshProUGUI scoreText;

  // //Getters and Setter
  public int getScore()
  {
    return scoreCount;
  }

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
      Debug.Log("Game Over - Bird hit pipe");
      // Destroy(this.gameObject);
      loadGameOver();
    }
    if (other.gameObject.tag == "OutOfBounds")
    {
      Debug.Log("Game Over - Out of Bounds");
      // Destroy(this.gameObject);
      loadGameOver();
    }
  }

  private void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Counter")
    {
      scoreCount++;
      Debug.Log(scoreCount);
      scoreText.text = "Score: " + scoreCount.ToString();
    }
  }

  private void loadGameOver()
  {
    SceneManager.LoadScene("FlappyBirdGameOver");
  }
}
