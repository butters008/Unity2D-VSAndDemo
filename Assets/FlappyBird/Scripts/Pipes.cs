using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
  [SerializeField] float xSpeed = 0.5f;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    MovePipes();
  }

  void MovePipes()
  {
    float xAmount = xSpeed * Time.deltaTime;
    transform.Translate(-xAmount, 0, 0);
  }
}
