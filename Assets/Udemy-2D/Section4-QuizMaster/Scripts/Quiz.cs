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
  QuestionsSO currentQuestion;
  [SerializeField] TextMeshProUGUI questionText;
  [SerializeField] List<QuestionsSO> questions = new List<QuestionsSO>();

  [Header("Answers")]
  [SerializeField] GameObject[] answerButtons;
  int correctAnswerIndex;
  bool answeredEarly;
  bool answeredEarly = true;

  [Header("Sprites")]
  [SerializeField] Sprite defaultAnswerSprite;
  [SerializeField] Sprite correctAnswerSprite;

  [Header("Timer")]
  [SerializeField] Image timerImage;
  Timer timer;

  [Header("Scoring")]
  [SerializeField] TextMeshProUGUI scoreText;
  ScoreKeeper scoreKeeper;

  [Header("Progress Bar")]
  [SerializeField] Slider progressBar;

  public bool isComplete;

  // Awake is the first inengine method that is used in heriarchy
  void Awake()
  {
    timer = FindObjectOfType<Timer>();
    scoreKeeper = FindObjectOfType<ScoreKeeper>();
    progressBar.maxValue = questions.Count;
    progressBar.value = 0;
  }

  void Update()
  {
    timerImage.fillAmount = timer.fillFraction;
    if (timer.loadNextQuestion)
    {
      if (progressBar.value == progressBar.maxValue)
      {
        isComplete = true;
        return;
      }

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
      questionText.text = currentQuestion.getQuestion();
      TextMeshProUGUI buttonText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
      buttonText.text = currentQuestion.getAnswer(i);
    }
  }

  public void OnAnswerSelected(int index)
  {
    answeredEarly = true;
    DisplayAnswer(index);
    SetButtonState(false);
    timer.CancelTimer();
    scoreText.text = "Score: " + scoreKeeper.CalcScore() + "%";
    if (progressBar.value == progressBar.maxValue)
    {
      isComplete = true;
    }

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
    if (questions.Count > 0)
    {

      SetButtonState(true);
      GetRandomQuestion();
      DisplayQuestion();
      SetButtonDefaultButtonSprite();
      progressBar.value++;
      scoreKeeper.IncrementQuestionSeen();
    }
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
    if (index == currentQuestion.getCorrectAnswerIndex())
    {
      questionText.text = "Correct";
      buttonImage = answerButtons[index].GetComponent<Image>();
      buttonImage.sprite = correctAnswerSprite;
      scoreKeeper.IncrementCorrectAnswers();
    }
    else
    {
      correctAnswerIndex = currentQuestion.getCorrectAnswerIndex();
      string correctAnwser = currentQuestion.getAnswer(correctAnswerIndex);
      buttonImage = answerButtons[correctAnswerIndex].GetComponent<Image>();
      questionText.text = "Sorry answer is " + correctAnwser;
    }
  }

  void GetRandomQuestion()
  {
    int index = Random.Range(0, questions.Count);
    currentQuestion = questions[index];

    if (questions.Contains(currentQuestion))
    {
      questions.Remove(currentQuestion);
    }
  }
}
