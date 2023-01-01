using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
  [SerializeField] Color baseColor, offsetColor;
  [SerializeField] SpriteRenderer _render;

  /*
Things I need to figure out
1) Getting position values from Grid
2) Storing position values
3) Being able to get position values
4) Have the mouse hover over the tile and it returns tile location
5)
*/

  public void colorTile(bool isOffset)
  {
    // _render.  .color = isOffset ? offsetColor : baseColor;
    if (isOffset)
    {
      _render.color = offsetColor;
    }
    else
    {
      _render.color = baseColor;
    }
  }

  public void deleteAfterCommit()
  {
    Debug.Log("Delete me!");
  }
}
