using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
  [SerializeField] private float speed;
  [SerializeField] private float speedIncrease;
  [SerializeField] private float turnSpeed;
  private int steerValue;

  // Update is called once per frame
  void Update()
  {
    IncreaseSpeed();
    transform.Rotate(0f, 0f, steerValue * turnSpeed * Time.deltaTime);
    transform.Translate(0, speed * Time.deltaTime, 0);
    //Debug.Log(speed);
  }

  void IncreaseSpeed()
  {
    speed += speedIncrease * Time.deltaTime;
  }

  public void TurnCar(int value)
  {
    steerValue = value;
    Debug.Log("Turning " + steerValue);
  }
}
