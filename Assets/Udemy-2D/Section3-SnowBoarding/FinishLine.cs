using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    private float reloadScene = 2.0f;
    [SerializeField] ParticleSystem finishEffect;


    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            Debug.Log("Finished");
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", reloadScene);
        }
    }

    void ReloadScene(){
        SceneManager.LoadScene("SnowBoarding");

    }
}
