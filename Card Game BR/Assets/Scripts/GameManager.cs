using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [Header("State Setup")]
    [SerializeField] private GameStateHandler stateHandler;
    [SerializeField] private PlayerData playerData;
    [SerializeField] private State Main;
    [SerializeField] private State CardSelect;
    [SerializeField] private State Movement;
    [SerializeField] private State CombatIntro;
    [SerializeField] private State Combat;
    [SerializeField] private State CombatOutro;
    [SerializeField] private State EnemyMain;
    [SerializeField] private State Summon;
    [SerializeField] private State HandPick;
    [SerializeField] private State EndTurn;
    [SerializeField] private State Fusion;

    public int playerID;
    private int currentPlayerTurnID;

    void Start()
    {
        stateHandler.SetState(Main);
    }

    //TODO Update to work with coroutines 
    //and update state machine for multiplayer
    void Update() 
    {
        MainState();
        EnemyMainState();
        HandPickState();
        SummonState();
        CardSelectState();
        MovementState();
        CombattingState();
        FusionState();
        EndTurnState();

        //currentPlayerTurnID = playerData.currentPlayerTurnID;
    }

    void MainState()
    {
        //Main ==>
        //HandPickState() OR CardSelectState() OR EndTurnState()
    }

    void EnemyMainState()
    {
        //set turn to next player
        //playerTurnHandler.NextPlayerTurn();

        //EnemyMain ==>
        //SummonState() OR MovementState() OR EndTurnState()
    }

    void HandPickState()
    {
        //Hand Pick ==> SummonState()
    }

    void SummonState() //Accessible by player and enemy
    {
        //Summon ==> MainState()
    }

    void CardSelectState()
    {
        //Card Select ==> MovementState()
    }
 
    void MovementState() //Accessible by player and enemy
    {
        //Movement ==> 
        //CombattingState() OR FusionState()
    }

    void CombattingState()
    {
        //Combat Intro ==> Combat ==> Combat Outro ==> 
        //MainState() OR EnemyMainState()
    }

    void FusionState()
    {
        //Fusion ==> 
        //MainState() OR EnemyMainState()
    }

    void EndTurnState()
    {
        //End Turn ==> EnemyMainState()
    }

    private bool PlayerTurn()
    {
        return (playerID == currentPlayerTurnID);
    }
}
