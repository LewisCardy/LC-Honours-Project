using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelectMenu : MonoBehaviour
{
    public GameObject[] playerModels;
    private int currentPos = 0;

    void Update(){
        
        if(currentPos < playerModels.Length){
            playerModels[currentPos].SetActive(true);
        } else {
            currentPos = 0;
        }

    }

    void Start(){
        currentPos = 0;
    }

    public void ClickNext(){  
        playerModels[currentPos].SetActive(false);
        currentPos ++;
       
    }

    public void ClickPrevious(){
        playerModels[currentPos].SetActive(false);
        currentPos --;
    }
}   
