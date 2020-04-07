using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTile : MonoBehaviour
{
    #region Instance Variables
    public int xPos { get; private set; }
    public int yPos { get; private set; }

    public Card card { get; private set; }
    public int cardCurrentHP { get; private set; }
    public Player player { get; private set; }
    public bool tileOccupied { get; private set; }
    public bool faceDown { get; private set; }
    public int owner { get; private set; }
    
    public int type { get; private set; }
    public GameObject terrainObject { get; private set; }

    [SerializeField] public GameObject[] terrainPrefabs;
    #endregion

    // Tile Constructor for creating tiles via board script
    public GameTile(int _xPos, int _yPos, Card _card = null, Player _player = null, 
                    bool _tileOccupied = false, bool _faceDown = true, int _owner = 0, int _type = 0)
    {
        // set this.xPos and this.yPos given board _xPos and _yPos
        this.xPos = _xPos;
        this.yPos = _yPos;
        // set default parameters _card, _player, _tileOccupied, _faceDown, _owner
        this.card = _card;
        this.player = _player;
        this.tileOccupied = _tileOccupied;
        this.faceDown = _faceDown;
        this.owner = _owner;
        // set default terrainObject given type and terrainPrefabs
        this.type = _type;
        this.terrainObject = terrainPrefabs[_type];
        // set terrainObject name given this.xPos and this.yPos
        this.terrainObject.name = this.xPos.ToString() + ", " + this.yPos.ToString();
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
        Debug.Log("tileOccupied:" + tileOccupied);
    }

    #region Setters
    public void SetType(int _type)
    {
        this.type = _type;
        this.terrainObject = terrainPrefabs[_type];
        Debug.Log("type changed for " + this.gameObject.name);
    }

    // Adding card to tile
    public void AddCard(Card _card)
    {
        if (!tileOccupied)
        {
            Debug.Log("card " + _card + "being added to " + this.gameObject.name);
            this.card = _card;
            this.tileOccupied = true;
            //this.owner = _card.owner;
            //this.cardCurrentHP = _card.hp;
        }
        else
        {
            Debug.Log("tile " + this.gameObject.name + " is already occupied by " + this.owner);
        }  
    }

    // Removing card from tile
    public void RemoveCard()
    {
        Debug.Log("card " + this.card + "being removed from " + this.gameObject.name);
        this.card = null;
        this.tileOccupied = false;
        this.owner = 0;
    }

    // Adding player to tile
    public void AddPlayer(Player _player)
    {
        if (!tileOccupied)
        {
            Debug.Log("player " + _player + "being added to " + this.gameObject.name);
            this.player = _player;
            this.tileOccupied = true;
            //this.owner = _player.owner;
        }
        else
        {
            Debug.Log("tile " + this.gameObject.name + " is already occupied by " + this.owner);
        }
    }

    // Removing player from tile
    public void RemovePlayer()
    {
        Debug.Log("player " + this.player + "being removed from " + this.gameObject.name);
        this.player = null;
        this.tileOccupied = false;
        this.owner = 0;
    }
    #endregion
}

