using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
  // Player player;
  // [SerializeField] TextMeshProUGUI scoreText;
  // int scoreCount;


  // private void Awake()
  // {
  //   player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
  //   // scoreCount = player.getScore();
  // }

  // private void Start()
  // {
  //   scoreCount = player.getScore();
  //   scoreText.text = scoreCount.ToString();
  // }



  public void replayLevel()
  {
    SceneManager.LoadScene("FlappyBirdGame");
  }

  /*
  NullReferenceException: Object reference not set to an instance of an object

  Common solution:
  -Check if your variable is attached to the object in question (you can find more clues in the other error lines).
  -You might destroy the object before you use it. Check if it’s the case.
  -You might start the coroutine before you define the variable. Either add a delay to the coroutine at the start so it can determine the value or start the coroutine after you’ve defined it.
  -Check if the suspected object is instantiated while you try to access it on that line.
  -Capitalization. Check all your variable spellings.
  -Check how you instantiate the object. Sometimes you shouldn’t use new keywords on a variable, but only when instantiating a non-mono behavior object. Check out below code snippet:

  Example of when you want to use new keyword of objects
    public class PinchZoom : MonoBehaviour
    {
      public float perspectiveZoomSpeed = 0.5f;        // The rate of change of the field of view in perspective mode.
      public float orthoZoomSpeed = 0.5f;        // The rate of change of the orthographic size in orthographic mode.
      public static GameObject other;
      public new Camera camera = other.GetComponent<Camera>();

      void Start()
      {

  -Check where your variables live. They might need to set to public. If you’re putting it to private, you need to reference it as a get component. For example, if the lifecontroller is attached to player and your player has tag you’d code:

  Example of what it should normally be (not always with the tags, just one way)
    lc = GameObject.FindObjectWithTag(“Player”).GetComponent<LifeController>();
      |-> You can also leave it private and tag it as [SerializeField]. This would be preferable to a potentially unnecessary and expensive call to FindObjectWithTag

  */


} //End of class
