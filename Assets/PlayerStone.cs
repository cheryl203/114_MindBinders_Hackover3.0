using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        theDiceRoller = GameObject.FindObjectOfType<DiceRoller>();
    }
    DiceRoller theDiceRoller;
    public Tile StartingTile;
    Tile currentTile;

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseUp(){
        if(theDiceRoller.IsDoneRolling == false){
            //we cant move yet.
            return;
        }
        int spacesToMove = theDiceRoller.DiceTotal;

        // Where should we end up 
        Tile finalTile = null;
        for(int i= 0;i< spacesToMove; i++){
            if(currentTile == null){
               finalTile = StartingTile;
          }
          else{
            finalTile = finalTile.NextTiles[0];
          }
        }
           if (finalTile == null)
           {
            return;
           }
           this.transform.position = finalTile.transform.position;
           currentTile = finalTile;
    }
}
