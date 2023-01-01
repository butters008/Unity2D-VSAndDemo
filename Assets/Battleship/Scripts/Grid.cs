using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
  [SerializeField] Tile tile;
  [SerializeField] int xLength;
  [SerializeField] int yLength;
  [SerializeField] Transform cam;
  void CreateGrid()
  {
    /*
    Things I need to figure out
    (I was a dip and got this working :facepalm)  Why calling Tile object is broke while and not GameObject
    1) Sending back to tile its cordinates in with seperate vars or as an array
    2) Determine how much more work it would be to get this working in isometric view
    3) IDK might be in both tile and here, work on Fog Of War mechanic
    4)

    Ideas for later
    1) Making some tiles or areas of grid non-navigation area
    2) FOR SURE LATER! - working heights/levels within the grid 
    */

    for (int x = 0; x < xLength; x++)
    {
      for (int y = 0; y < yLength; y++)
      {
        var spawnTile = Instantiate(tile, new Vector3(x, y), Quaternion.identity);
        var isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
        spawnTile.colorTile(isOffset);
        spawnTile.name = $"Tile{x}-{y}";
        Debug.Log("(" + x + " , " + y + ")");
      }
    }

    //Not sure why I am doing this at -10, doing it for right now.
    cam.transform.position = new Vector3((float)xLength / 2 - 0.5f, (float)yLength / 2 - 0.5f, -10);
  }//end of CreateGrid

  private void Start()
  {
    CreateGrid();
  }

  public void deleteAfterCommit()
  {
    Debug.Log("Delete me!");
  }

}//End of class
