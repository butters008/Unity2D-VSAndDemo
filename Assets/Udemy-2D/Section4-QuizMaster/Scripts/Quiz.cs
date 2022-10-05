using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Quiz : MonoBehaviour
{

    //Neat trick to write down later - padlock on top of
    //inspector locks it so you don't have to fight it when
    //adding new things into inspector (example adding something into array)

    [SerializeField] QuestionsSO question;
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] GameObject[] answerButtons;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < answerButtons.Length; i++){
            questionText.text = question.getQuestion();
            TextMeshProUGUI buttonText =  answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = question.getAnswer(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
