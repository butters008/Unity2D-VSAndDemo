using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  Quiz quiz;
  EndScript endScript;

  /*
  What we are doing here and why it is different from Quiz.cs.  
  We are using Awake to find the game objects, but since the objects
  are not from this script like progress bar was initialized in quiz.cs
  We are having to set the game object in start after we initalize. 
  */
  private void Awake()
  {
    quiz = FindObjectOfType<Quiz>();
    endScript = FindObjectOfType<EndScript>();
  }
  void Start()
  {
    quiz.gameObject.SetActive(true);
    endScript.gameObject.SetActive(false);
  }

  void Update()
  {
    if (quiz.isComplete)
    {
      quiz.gameObject.SetActive(false);
      endScript.gameObject.SetActive(true);
      endScript.ShowFinalScore();
    }
  }

  public void replayLevel()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }
}
