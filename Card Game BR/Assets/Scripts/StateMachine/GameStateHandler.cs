using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "StateMachine/StateHandlers/GameStateHandler")]
public class GameStateHandler : ScriptableObject
{

    public State currentState { get; set; }
    //public State savedState { get; set; }

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

    private void OnEnable()
    {
        currentState = Main;
        //savedState = MoveObjectState;
    }


    public void SetState(State _state)
    {
        if (currentState == _state)
        {
            return;
        }
        else
        {
            currentState = _state;
        }
    }

}

