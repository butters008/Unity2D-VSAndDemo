using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
  [SerializeField] GameObject objectToSpawn;
  bool timeToRespawn = false;
  
  Vector2 randomPosition;

  private void Start() {
    StartCoroutine(RespawnPipes());   
  }
  
  void Update()
  {
    if(timeToRespawn) {
    StartCoroutine(RespawnPipes());        
    }
   // Destroy (objectToSpawn, 5);
  }

  IEnumerator RespawnPipes(){
    randomPosition = new Vector2(
      Random.Range(7, 7),
      Random.Range(2, -2));

    timeToRespawn = false;
    yield return new WaitForSeconds(5); 
    GameObject newPipes = Instantiate(objectToSpawn, randomPosition, transform.rotation);
    timeToRespawn = true;
  }
  
  // private void OnCollisionEnter2D(Collision2D other) {
  //   Debug.Log("Triggered in Spanner");
  // }

}
