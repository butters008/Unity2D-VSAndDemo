using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
  int correctAnsers = 0;
  int questionsSeen = 0;

  public int GetCorrectAnswers()
  {
    return correctAnsers;
  }

  public void IncrementCorrectAnswers()
  {
    correctAnsers++;
  }

  public int GetQuestionSeen()
  {
    return questionsSeen;
  }

  public void IncrementQuestionSeen()
  {
    questionsSeen++;
  }

  public int CalcScore()
  {
    return Mathf.RoundToInt(correctAnsers / (float)questionsSeen * 100);
  }

}
