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

}
