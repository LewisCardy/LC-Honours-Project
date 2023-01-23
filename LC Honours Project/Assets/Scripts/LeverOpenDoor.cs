using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverOpenDoor : MonoBehaviour
{
    public Animator doorAnimator;
    private bool isTriggered;
    private void OnTriggerEnter(Collider collider){
        if(isTriggered == false){
            if(collider.tag == "Lever Moveable"){
                if(gameObject.name == "Lever Up Trigger"){
                    doorAnimator.Play("Door Close", 0, 0.0f);
                } else if (gameObject.name == "Lever Down Trigger"){ 
                    doorAnimator.Play("Door Open", 0, 0.0f);
                    Debug.Log("sdikofjiopsdjfi0jsdifp");
                }
                isTriggered = true;
            }
        }
    }
    private void OnTriggerExit(Collider collider){
        isTriggered = false;
    }
}
