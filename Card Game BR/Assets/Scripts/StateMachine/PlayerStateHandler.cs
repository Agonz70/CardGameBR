using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "StateMachine/StateHandlers/PlayerStateHandler")]
public class PlayerStateHandler : ScriptableObject
{

    public int currentPlayerTurnID { get; private set; }

    //TODO Add a list of players for players on network

    public void NextPlayerTurn()
    {
        currentPlayerTurnID++;
    }

}

