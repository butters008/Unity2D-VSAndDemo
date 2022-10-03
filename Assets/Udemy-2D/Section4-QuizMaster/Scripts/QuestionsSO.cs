using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionsSO : ScriptableObject
{
    [TextArea(2, 6)] 
    [SerializeField] string quizQuestion = "Enter your question here";

    // This is a getter function
    public string getQuestion(){
        return quizQuestion;
    }
}
