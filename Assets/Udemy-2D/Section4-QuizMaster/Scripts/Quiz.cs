using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{

  //Neat trick to write down later - padlock on top of
  //inspector locks it so you don't have to fight it when
  //adding new things into inspector (example adding something into array)  
  //***NOTE*** I have no idea on what a header is ATM, on 10/12/22 or what they will even do for us
  [Header("Questions")] //This is for the inspector!!! COOL!!!!
  [SerializeField] QuestionsSO question;
  [SerializeField] TextMeshProUGUI questionText;

  [Header("Answers")]
  [SerializeField] GameObject[] answerButtons;
  int correctAnswerIndex;
  bool answeredEarly;

  [Header("Sprites")]
  [SerializeField] Sprite defaultAnswerSprite;
  [SerializeField] Sprite correctAnswerSprite;

  [Header("Timer")]
  [SerializeField] Image timerImage;
  Timer timer;

  // Start is called before the first frame update
  void Start()
  {
    timer = FindObjectOfType<Timer>();
    DisplayQuestion();


  }

  void Update()
  {
    timerImage.fillAmount = timer.fillFraction;
    if (timer.loadNextQuestion)
    {
      answeredEarly = false;
      GetNextQuestion();
      timer.loadNextQuestion = false;

    }
    else if (!answeredEarly && !timer.isAnsweringQuestion)
    {
      DisplayAnswer(-1);
      SetButtonState(false);
    }

  }

  //I had this public, but he had it as private
  void DisplayQuestion()
  {
    for (int i = 0; i < answerButtons.Length; i++)
    {
      questionText.text = question.getQuestion();
      TextMeshProUGUI buttonText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
      buttonText.text = question.getAnswer(i);
    }
  }

  public void OnAnswerSelected(int index)
  {
    answeredEarly = true;
    DisplayAnswer(index);
    SetButtonState(false);
    timer.CancelTimer();
  }

  public void SetButtonState(bool state)
  {
    for (int i = 0; i < answerButtons.Length; i++)
    {
      Button button = answerButtons[i].GetComponent<Button>();
      button.interactable = state;
    }
  }

  void GetNextQuestion()
  {
    SetButtonState(true);
    DisplayQuestion();
    SetButtonDefaultButtonSprite();
  }

  void SetButtonDefaultButtonSprite()
  {
    for (int i = 0; i < answerButtons.Length; i++)
    {
      Image buttonImage = answerButtons[i].GetComponent<Image>();
      buttonImage.sprite = defaultAnswerSprite;
    }
  }

  void DisplayAnswer(int index)
  {
    Image buttonImage;
    if (index == question.getCorrectAnswerIndex())
    {
      questionText.text = "Correct";
      buttonImage = answerButtons[index].GetComponent<Image>();
      buttonImage.sprite = correctAnswerSprite;
    }
    else
    {
      correctAnswerIndex = question.getCorrectAnswerIndex();
      string correctAnwser = question.getAnswer(correctAnswerIndex);
      buttonImage = answerButtons[correctAnswerIndex].GetComponent<Image>();
      questionText.text = "Sorry answer is " + correctAnwser;
    }
  }
}
