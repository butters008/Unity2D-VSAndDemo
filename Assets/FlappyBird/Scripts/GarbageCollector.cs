using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageCollector : MonoBehaviour
{
  // [SerializeField] GameObject objectToDestroy;
  [SerializeField] float xSpeed = 0.5f;


  private void Update() {
    moveGC();
  }
  // [SerializeField] GameObject objectToDestroy;
  private void OnTriggerEnter2D(Collider2D other) {
    Debug.Log("Triggered in GC");
    Destroy(other.gameObject);
  }
  void moveGC(){
    float xAmount = xSpeed * Time.deltaTime;  
    transform.Translate(xAmount, 0, 0);
  }
}
