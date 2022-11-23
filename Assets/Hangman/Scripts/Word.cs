using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Word : MonoBehaviour
{
  [Header("Word Logic")]
  [SerializeField] string word = "Hello";
  [SerializeField] TextMeshProUGUI wordText;

  private void Awake()
  {
    
  }
    // Start is called before the first frame update
    void Start()
    {
      wordText.text = word;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
