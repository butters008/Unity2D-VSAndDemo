using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "WordSO", menuName = "WordSO", order = 0)]
public class WordSO : ScriptableObject {
  [SerializeField] string word;

  public void getWord(){
    return word;
  }
  
}

