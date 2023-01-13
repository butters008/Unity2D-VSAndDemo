using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseUnit : MonoBehaviour
{
  //Vars
  [SerializeField] int moveSpace;
  [SerializeField] int unitHealth;
  [SerializeField] int unitDamage;

  //Getters
  public int getUnitHealth()
  {
    return unitHealth;
  }

  public int getUnitDamage()
  {
    return unitDamage;
  }

  public int getMoveSpace()
  {
    return moveSpace;
  }

  //Setters
  public void setUnitHealth(int health)
  {
    unitHealth = health;
  }

  public void setUnitDamage(int damage)
  {
    unitDamage = damage;
  }

  //Might need to change var
  public void setMoveSpace(int moveSpace)
  {
    this.moveSpace = moveSpace;
  }
}
