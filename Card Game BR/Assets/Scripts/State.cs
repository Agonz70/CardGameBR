using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "StateMachine/State")]
public class State : ScriptableObject
{
    public Queue<Phase> phases;
    public Transitions[] transitions;

    public void UpdateState()
    {

    }
    public void ExeState()
    {

    }
    public void CurrentTransitions()
    {

    }
}

