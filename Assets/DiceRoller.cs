using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceRoller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DiceValues = new int[4];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int[] DiceValues;
    public int DiceTotal;
    public bool doneRolling = false;
    public Sprite[] DiceImageOne;
    public Sprite[] DiceImageZero;
    public void NewTurn(){
        doneRolling = false;
    }


    public void RollTheDice() {
            DiceTotal=0;
            for (int i = 0; i < DiceValues.Length; i++)
            {
                DiceValues[i] = Random.Range(0,2);
                DiceTotal += DiceValues[i];
                if (DiceValues[i]==0)
                {
                   this.transform.GetChild(i).GetComponent<Image>().sprite=
                       DiceImageZero[ Random.Range(0, DiceImageZero.Length) ];
                }
                else
                {
                     this.transform.GetChild(i).GetComponent<Image>().sprite=
                       DiceImageOne[ Random.Range(0, DiceImageOne.Length) ];
                }
               doneRolling = true;
            }

    }
}
