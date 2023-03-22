using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverInteraction : MonoBehaviour
{
    //Script to handle the lever being pulled up and down
    //Applicable for both the up and down triggers
    private bool isTriggered;
    public AudioSource audioSource;
    public AudioClip leverClick;
    private void OnTriggerEnter(Collider collider){
        if(isTriggered == false){
            if(collider.tag == "Lever Moveable"){ //if the lever in the switch hits one of the triggers something happens
                if(gameObject.name == "Lever Up Trigger"){ //if lever pulled up
                    Debug.Log("Lever Up");
                    audioSource.clip = leverClick;
                    audioSource.Play();
                } else if (gameObject.name == "Lever Down Trigger"){ //if lever pulled down
                    Debug.Log("Lever Down");
                    audioSource.clip = leverClick;
                    audioSource.Play();
                }
                isTriggered = true;
            }
        }
    }
    private void OnTriggerExit(Collider collider){
        isTriggered = false;
    }
}
