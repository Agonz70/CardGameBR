using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public State CurrentState;
    public List<Player> Player;
    public Card[] Effects2Trigger;
    private State currentState;
    private Card pickedCard;
    private Card targetCard;
    private GameBoard board;

    private void Start()
    {
        //board.GenerateBoard();
    }

    private void UpdateBoardTile(int _xPos, int _yPos, int _type)
    {
        Debug.Log("Updated tile[" + _xPos + ", " + _yPos + "] type to type[" + _type + "]");
        board.tiles[_xPos, _yPos].SetType(_type);
    }

}
