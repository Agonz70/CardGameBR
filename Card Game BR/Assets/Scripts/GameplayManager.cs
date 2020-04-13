using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    private static GameplayManager _instance;
    public static GameplayManager Instance{
        get{
            
            
            return _instance;
        }
    }


public bool phaseFinishedforNextState = false;
    public bool CardEffectOver = false;

        public State CurrentState;
    

     void Awake(){
        if(_instance == null)
        _instance = this;
        else{
            Destroy(this.gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
     }


    
    void Start()
    {
        Board.Instance.Initialize();

        Cursor.Instance.MovetoTile(0,0);
        
    }


  
    

    // Update is called once per frame
    void Update()
    {
        //CurrentState.UpdateState(this);
    }
    
    public void TransitionToState(State nextState){
        if(nextState != CurrentState){
            CurrentState = nextState;
        }
    }

   
}
