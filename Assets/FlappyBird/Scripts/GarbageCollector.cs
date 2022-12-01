using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageCollector : MonoBehaviour
{
  // [SerializeField] GameObject objectToDestory;
  private void OnTriggerEnter2D(Collider2D other)
  {
    Debug.Log("Triggered in GC");
    Destroy(other.gameObject);
  }
}
