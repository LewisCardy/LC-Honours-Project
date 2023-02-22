using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverActivateMenu : MonoBehaviour
{
    //Script to handle the lever being pulled up and down
    //Applicable for both the up and down triggers
    private bool isTriggered;
    public GameObject menu;
    private void OnTriggerEnter(Collider collider){
        if(isTriggered == false){
            if(collider.tag == "Lever Moveable"){ //if the lever in the switch hits one of the triggers something happens
                if(gameObject.name == "Lever Up Trigger"){ //if lever pulled up
                    Debug.Log("Lever Up");
                } else if (gameObject.name == "Lever Down Trigger"){ //if lever pulled down
                    Debug.Log("Lever Down");
                    menu.SetActive(true);
                }
                isTriggered = true;
            }
        }
    }
    private void OnTriggerExit(Collider collider){
        isTriggered = false;
    }
}
