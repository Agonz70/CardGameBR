using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTile : MonoBehaviour
{
    public int xPos { get; private set; }
    public int yPos { get; private set; }
    public Card card { get; private set; }
    public Player player { get; private set; }
    public bool faceDown { get; private set; }
    public int cardCurrentHP { get; private set; }
    public int owner { get; private set; }
    public int type { get; private set; }
    public GameObject terrainObject { get; private set; }
    public bool occupied { get; private set; }

    [SerializeField] public GameObject[] terrainPrefabs;

    // Initialize tile data not set by board script 
    public void InitiliazeTileData()
    {
        player = null; // no player
        card = null; // no card
        faceDown = true; // default card face down
        owner = 0; // no owner
        type = 0; // no type
        terrainObject = terrainPrefabs[0]; // no type object
        occupied = false; // no player or card
    }

    // Print all values of tile data for debugging purposes
    public void PrintTileData()
    {
        Debug.Log("xPos & yPos: (" + xPos + ", " + yPos + ")");
        Debug.Log("Player:" + player);
        Debug.Log("Card:" + card);
        Debug.Log("faceDown:" + faceDown);
        Debug.Log("cardCurrentHp:" + cardCurrentHP);
        Debug.Log("owner" + owner);
        Debug.Log("type:" + type);
        Debug.Log("occupied:" + occupied);
    }

    // TODO edit this method
    // Instantiate tiles done by board script
    public static GameObject InstantiateTile(GameObject prefab, Vector3 worldPosition, Transform board)
    {
        GameObject tile = Instantiate(prefab, worldPosition, Quaternion.identity, board);
        tile.name = worldPosition.x + ", " + worldPosition.y;
        return tile;
    }

    public void SetType(int _type)
    {
        this.type = _type;
        this.terrainObject = terrainPrefabs[_type];
        Debug.Log("type changed for " + this.gameObject.name);
    }

    public void SetCard(Card _card)
    {
        this.card = _card;
        this.occupied = true;
    }

}

