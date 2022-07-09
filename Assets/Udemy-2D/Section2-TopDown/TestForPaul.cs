using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestForPaul : MonoBehaviour
{

    // [SerializeField] GameObject gameObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ChangeName(GameObject obj){
        if(obj.tag == "ouch"){
            int num = 1;
            Debug.Log("This is the OG name" + obj.name);
            obj.name = "Renamed Obj-" + num;
            num++;
        }
    }
}
