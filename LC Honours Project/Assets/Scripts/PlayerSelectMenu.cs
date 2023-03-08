using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The select menu
public class PlayerSelectMenu : MonoBehaviour
{
    public GameObject[] playerModels; //array of display rigs
    public GameObject backButton;
    private int currentPos = 0;

    public MenuManager menuManager;
    void Update(){
        if(currentPos < playerModels.Length){ //used for looping the array if the index exceeds the length
            playerModels[currentPos].SetActive(true); //sets the display model to be the index
            menuManager.setPlayerRig(playerModels[currentPos].name); //sends the name of the chosen rig to the manager
        } else {
            currentPos = 0;
        }
        if(currentPos == 0){
            backButton.SetActive(false);
        } else {
            backButton.SetActive(true);
        }
    }

    void Start(){
        currentPos = 0;
        playerModels[currentPos].SetActive(true); //defaults
        menuManager.setPlayerRig(playerModels[currentPos].name);
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
