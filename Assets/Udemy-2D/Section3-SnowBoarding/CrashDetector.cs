using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ouch"){
            Debug.Log("Going to Restart Level");
            SceneManager.LoadScene("SnowBoarding");

            //If there was no other scence in the game, it would load the scene that would be considered 0
            //Both ways work I think, since there are 5 overload methods.  Maybe there is something we would benefit with this
            //Incase there is something you have to save and load, like settings.  Game data should be persistence so that should not 
            //Affect this
            // SceneManager.LoadScene(0);
        }
    }
}
