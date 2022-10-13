using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    [SerializeField] float timeToShowAnwser = 3f;
    [SerializeField] float timeToCompleteQuestion = 5.0f;
    float timerValue;

    //He made these public, I dont like it
    public bool isAnsweringQuestion = false;
    public float fillFraction;
    public bool loadNextQuestion = false;

    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer()
    {
        if(isAnsweringQuestion){

            if(timerValue > 0){
                fillFraction = timerValue / timeToCompleteQuestion;
            }
            else{
                isAnsweringQuestion = false;
                timerValue = timeToShowAnwser;
            }
        }
        else{
            if(timerValue > 0){
                fillFraction = timerValue / timeToShowAnwser;
            }
            else{
                isAnsweringQuestion = true;
                timerValue = timeToCompleteQuestion;
                loadNextQuestion = true;
            }
        }
        timerValue -= Time.deltaTime;
        Debug.Log(timerValue);
    }

    public void CancelTimer(){
        timerValue = 0;
    }
}
