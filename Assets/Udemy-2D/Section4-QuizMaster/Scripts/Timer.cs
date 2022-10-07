using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    [SerializeField] float timeToShowAnwser = 3f;
    [SerializeField] float timeToCompleteQuestion = 5.0f;
    float timerValue;

    public bool isAnsweringQuestion = false;

    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer()
    {
        if(isAnsweringQuestion){
            if(timerValue <= 0){
                isAnsweringQuestion = false;
                timerValue = timeToShowAnwser;
            }
        }
        else{
            if(timerValue <= 0){
                isAnsweringQuestion = true;
                timerValue = timeToCompleteQuestion;
            }
        }
        timerValue -= Time.deltaTime;
        Debug.Log(timerValue);
    }
}
