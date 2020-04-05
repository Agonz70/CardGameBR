using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public bool cursorhighlighting { get; private set; }
    public int type { get; private set; }
    public bool occupied { get; private set; }

    public void InitiliazeTileData()
    {
        cursorhighlighting = false;
        type = 0;
        occupied = false;
    }

    public void Print()
    {
        Debug.Log(cursorhighlighting);
        Debug.Log(type);
        Debug.Log(occupied);
    }

    public static GameObject InstantiateTile(GameObject prefab, Vector3 worldPosition, Transform board)
    {
        GameObject tile = Instantiate(prefab, worldPosition, Quaternion.identity, board);
        tile.name = worldPosition.x + ", " + worldPosition.y;
        return tile;
    }


}
