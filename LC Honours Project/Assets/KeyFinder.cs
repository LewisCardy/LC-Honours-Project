using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyFinder : MonoBehaviour
{
    private GameObject gameManagerObj;
    private GameManager gameManager;
    public TMPro.TextMeshProUGUI keyTxt;
    void Start(){
        gameManagerObj = GameObject.Find("GameManager"); //find the game manager object
        gameManager = gameManagerObj.GetComponent<GameManager>(); //get the game manager script
        keyTxt.text = (gameManager.keysCollected/2).ToString(); //updates the text to the number of keys collected /2 because of some issues with collection
    }
}
