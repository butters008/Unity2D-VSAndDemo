using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobPlayer : MonoBehaviour
{

  [Header("Basic Character")]
  [SerializeField] float moveSpeed = 2f;
  [SerializeField] int health = 10;



  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    MoveBob();
  }

  void MoveBob()
  {
    // if(Input.GetKeyDown("D")){
    float moveAmount = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
    transform.Translate(moveAmount, 0, 0);
    // }
  }


}
