using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScript : MonoBehaviour
{
  [SerializeField] TextMeshProUGUI finalScoreText;
  ScoreKeeper scoreKeeper;

  private void Start()
  {
    scoreKeeper = FindObjectOfType<ScoreKeeper>();
  }

  public void ShowFinalScore()
  {
    finalScoreText.text = "Congrats! \n You got a score of" + scoreKeeper.CalcScore() + "%";
  }
}
