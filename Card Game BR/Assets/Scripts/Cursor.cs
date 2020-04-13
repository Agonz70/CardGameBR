using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    private static Cursor _instance;
    public static Cursor Instance{
        get{
            
            
            return _instance;
        }
    }

    

     void Awake(){
        if(_instance == null)
        _instance = this;
        else{
            Destroy(this.gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
     }

     float MoveAgainTimer;
     public float MaxMAT;

     private void Update() {
         MoveAgainTimer+= Time.deltaTime;
         
         if(MoveAgainTimer >= MaxMAT){
            
         if(Input.GetAxis("Horizontal")>0.3){
             MovetoTile(xpos+1,ypos);
              MoveAgainTimer = 0;
         }
         else if(Input.GetAxis("Horizontal")<-0.3){
             MovetoTile(xpos-1,ypos);
              MoveAgainTimer = 0;
         }
         else if(Input.GetAxis("Vertical")>0.3){
             MovetoTile(xpos,ypos+1);
              MoveAgainTimer = 0;
         }
         else if(Input.GetAxis("Vertical")<-0.3){
             MovetoTile(xpos,ypos-1);
              MoveAgainTimer = 0;
         }
         }

         
     }

     int xpos = 0;
    int ypos=0;

     public void MovetoTile(int x, int y){
         if( x<Board.Instance.xLength&& y<Board.Instance.yLength && x>=0 && y>=0){
         xpos = x;
         ypos = y;
         transform.position = Board.Instance.GetTiles(x,y).tilePosition;
         }
     }

     public Tiles GetCurrentTile(){
         return Board.Instance.GetTiles(xpos,ypos);
     }
    

}
