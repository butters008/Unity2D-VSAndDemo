using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene("Mobile - Simple Driving Game");
    }

    public void PauseLevel()
    {
        Debug.Log("Paused");
    }
}
