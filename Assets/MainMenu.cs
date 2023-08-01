using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //I am going to assume that this script will change alot, going on a cuff to build something local
    public void goToGameCarCrash()
    {
        SceneManager.LoadScene("Mobile - Simple Driving Game");
    }
}
