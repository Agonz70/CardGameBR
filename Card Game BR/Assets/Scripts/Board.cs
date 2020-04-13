using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    #region Instance Variables
    public GameObject[,] tileMap; // TODO [AIG] store a 2D Array of Tile data rather then tile gameobjects 
    [SerializeField] public Vector2Int dimensions; // x and y dimensions of board
    [SerializeField] public float padding; // space in-between tiles
    [SerializeField] public GameObject prefab; // tile prefab // TODO [AIG] when we have other tile assets, then this definetly needs to be handled by the tile data
    [SerializeField] public Transform board; // parent where tiles will be put under // TODO [AIG] set up, so that it is broken into columns and rows
    #endregion

    #region Instance Variables for Demos/Tests
    [SerializeField] public Vector3Int setTileType; // only set up for demo of tile changes
    private Color[] tileTypes = new Color[5]; // only set up for demo of tile changes // TODO [AIG] move to tile class
    private int x, y, type; // only set up for demo of tile changes
    public bool letUsParty; // fun party button
    public bool testingTileChanges; // testing tile changes button
    #endregion

    #region Unity Events
    private void Update()
    {
        if (testingTileChanges)
            SetTileType(x, y, type);
    }

    private void Start()
    {
        GenerateBoard();

        if (letUsParty)
            StartCoroutine(randomDanceParty());
    }
    #endregion

    #region Board
    /* Generate a board of tiles that is a given x and y dimensions */
    private void GenerateBoard()
    {
        tileMap = new GameObject[dimensions.x, dimensions.y];

        for (int i = 0; i < dimensions.x; i++)
        {
            for (int j = 0; j < dimensions.y; j++)
            {
                CreateTile(i, j);
            }
        }
    }

    /* Creates a tile gameobject for every tile on board generated */
    private void CreateTile(int x, int y)
    {
        Debug.Log("generating tile [" + x + "][" + y + "]");
        tileMap[x, y] = Tile.InstantiateTile(prefab, new Vector3(x * (padding + 1), y * (padding + 1), 0), board);
    }
    #endregion

    #region Tile Property Get & Set
    private void SetTileType(int x, int y, int type)
    {
        tileMap[x, y].GetComponent<Tile>().SetType(type);
        tileMap[x, y].GetComponent<Renderer>().material.color = tileTypes[type]; //TODO move gameobject tile to Tile Class
    }

    private int GetTileType(int x, int y)
    {
        int tileType = tileMap[x, y].GetComponent<Tile>().type;
        return tileType;
    }
    #endregion

    #region Extra
    // Move to Tile Class and add in names, such as fire, ice, etc...
    private void InitTileProperites()
    {
        tileTypes[1] = Color.red;
        tileTypes[2] = Color.green;
        tileTypes[3] = Color.blue;
        tileTypes[4] = Color.black;

        x = setTileType.x;
        y = setTileType.y;
        type = setTileType.z;
    }

    public IEnumerator randomDanceParty()
    {
        for (int i = 0; i < dimensions.x; i++)
        {
            for (int j = 0; j < dimensions.y; j++)
            {
                tileMap[i, j].GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
                Vector3 tempPosition = tileMap[i, j].transform.position;
                tempPosition.x = Random.value * 2;
                tempPosition.y = Random.value * 4;
                tempPosition.z = Random.value * 8;
                tileMap[i, j].transform.position = tempPosition;
            }
        }

        yield return new WaitForSeconds(5f);

        StartCoroutine(randomDanceParty());
    }
    #endregion
}
