using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{

    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] float loadTime = 2.0f;
    [SerializeField] AudioClip crashSFX;
    PlayerController playerController;
    private bool hasCrashed = false;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ouch" && !hasCrashed){
            Debug.Log("Going to Restart Level");
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            FindObjectOfType<PlayerController>().disableControls(); //This is how he did it and it works maybe because of components. 
            Invoke("ReloadScene", loadTime);
            hasCrashed = true;
            // playerController.disableControls(); //This is how I did this...and this does not work
            // SceneManager.LoadScene("SnowBoarding");

            //If there was no other scence in the game, it would load the scene that would be considered 0
            //Both ways work I think, since there are 5 overload methods.  Maybe there is something we would benefit with this
            //Incase there is something you have to save and load, like settings.  Game data should be persistence so that should not 
            //Affect this
            // SceneManager.LoadScene(0);
        }
    }

    private void ReloadScene(){
        SceneManager.LoadScene("SnowBoarding");
    }
}
