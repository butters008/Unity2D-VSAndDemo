using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
  /*
  Things I need to do in order to complete the battlemanager and complete turn-based combat
  - Hard code a player class (might inheight from character/ship)
  - Hard code a enemy class (might inheight from character/ship)
  - Get the classes to be read from in here
  - Code in open to attack, defend, and end turn
  - Start battle
  - Test battle
  - Complete battle (one side loose)
 */

  //Vars and Object
  int turnCounter = 0;
  PlayerManager playerManager;
  int playerNumberCount;

  private void Awake()
  {
    playerManager = FindObjectOfType<PlayerManager>();
  }

  private void Start()
  {
    playerNumberCount = playerManager.getNumberOfUnits();
    Debug.Log(playerNumberCount);
  }


  private void Update()
  {

  }

  void battleProcess()
  {

  }






}
