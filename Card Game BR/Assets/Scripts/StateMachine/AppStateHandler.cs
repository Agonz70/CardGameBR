using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "StateMachine/StateHandlers/AppStateHandler")]
public class AppStateHandler : ScriptableObject
{

    public State currentState { get; set; }
    //public State savedState { get; set; }

    [SerializeField] private State Main;


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

