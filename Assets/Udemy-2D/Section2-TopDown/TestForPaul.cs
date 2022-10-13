using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestForPaul : MonoBehaviour
{

    private char renameLetter = 'a';

    void ChangeName(GameObject obj){
        if(obj.tag == "ouch"){
            // int num = 1;
            Debug.Log("This is the OG name" + obj.name);
            obj.name = obj.name + " " + renameLetter;
            renameLetter++;
        }
    }
}
