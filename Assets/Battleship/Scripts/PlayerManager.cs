using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
  //Vars and Objects
  [SerializeField] int numberOfUnits;

  public int getNumberOfUnits()
  {
    return numberOfUnits;
  }

  public void setNumberOfUnits(int numberOfUnits)
  {
    this.numberOfUnits = numberOfUnits;
  }
}
