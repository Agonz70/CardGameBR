using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoard : MonoBehaviour
{
    #region Instance Variables
    public GameTile[,] tiles { get; private set; }

    [SerializeField] public int xDim; // x dimension of board
    [SerializeField] public int yDim; // y dimension of board
    [SerializeField] public float padding; // space in-between tiles
    [SerializeField] public Transform board; // parent where tiles will be put under // TODO [AIG] set up, so that it is broken into columns and rows
    [SerializeField] GameObject[] terrainPrefabs; // collection of terrain type prefabs for tiles // TODO [AIG] move to game tile class
    #endregion

    #region Unity Events
    // TODO remove Unity Start() from this script
    private void Start()
    {
        GenerateBoard();
    }
    #endregion

    #region Board
    /* Board Constructor */
    public GameBoard(int _xDim = 0, int _yDim = 0, float _padding = 0, Transform _board = null, GameObject[] _terrainPrefabs = null)
    {
        this.xDim = _xDim;
        this.yDim = _yDim;
        this.padding = _padding;
        this.board = _board;
        this.terrainPrefabs = _terrainPrefabs;
    }

    /* Generate a board of tiles that is a given x and y dimensions */
    private void GenerateBoard()
    {
        tiles = new GameTile[xDim, yDim];

        for (int x = 0; x < xDim; x++)
        {
            for (int y = 0; y < yDim; y++)
            {
                CreateTile(x, y);
            }
        }
    }

    /* Creates a tile gameobject for every tile on board generated */
    private void CreateTile(float _x, float _y)
    {
        Debug.Log("generating tile [" + _x + "][" + _y + "]");
        tiles[(int)_x, (int)_y] = new GameTile(_xPos: _x * (padding + 1), _yPos: _y * (padding + 1), _board: board, _terrainPrefabs: terrainPrefabs);
    }
    #endregion
}
