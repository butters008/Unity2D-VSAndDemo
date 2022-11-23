using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
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
        }
    }

    void Jump(){
      Debug.Log("Hello");
    }
}
