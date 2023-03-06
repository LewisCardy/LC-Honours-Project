using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The select menu
public class PlayerSelectMenu : MonoBehaviour
{
    public GameObject[] playerModels; //array of display rigs
    private int currentPos = 0;

    public GameManager gameManager;
    void Update(){
        if(currentPos < playerModels.Length){ //used for looping the array if the index exceeds the length
            playerModels[currentPos].SetActive(true); //sets the display model to be the index
            gameManager.setPlayerRig(playerModels[currentPos].name); //sends the name of the chosen rig to the game manager
        } else { //sets index back to 0
            currentPos = 0;
        }
    }

    void Start(){
        currentPos = 0;
        playerModels[currentPos].SetActive(true); //defaults
        gameManager.setPlayerRig(playerModels[currentPos].name);
    }

    public void ClickNext(){  //when the next button is clicked increase index
        playerModels[currentPos].SetActive(false);
        currentPos ++;
       
    }

    public void ClickPrevious(){ //when the previous button clicked decrease index
        playerModels[currentPos].SetActive(false);
        currentPos --;
    }
}   
