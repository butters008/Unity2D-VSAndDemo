using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    private float reloadScene = 2.0f;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            Debug.Log("Finished");
            Invoke("ReloadScene", reloadScene);
        }
    }

    void ReloadScene(){
        SceneManager.LoadScene("SnowBoarding");

    }
}
