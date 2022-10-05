using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionsSO : ScriptableObject
{
    [TextArea(2, 6)] 
    [SerializeField] string quizQuestion = "Enter your question here";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex;

    // This is a getter function
    public string getQuestion(){
        return quizQuestion;
    }

    public int getCorrectAnswerIndex(){
        return correctAnswerIndex;
    }

    public string getAnswer(int index){
        return answers[index];
    }
}
