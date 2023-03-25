using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverOpenTrapDoor : MonoBehaviour
{
    public Animator doorAnimator;
    private bool isTriggered;
    public AudioSource switchSource;
    public AudioSource doorSource;
    public AudioClip leverClick;
    public AudioClip doorSqueak;
    private void OnTriggerEnter(Collider collider){
        if(isTriggered == false){
            if(collider.tag == "Lever Moveable"){
                if(gameObject.name == "Lever Up Trigger"){
                    switchSource.clip = leverClick;
                    switchSource.Play();
                    doorAnimator.Play("Trap Door Close", 0, 0.0f);
                    doorSource.clip = doorSqueak;
                    doorSource.Play();
                } else if (gameObject.name == "Lever Down Trigger"){ 
                    switchSource.clip = leverClick;
                    switchSource.Play();
                    doorAnimator.Play("Trap Door Open", 0, 0.0f);
                    doorSource.clip = doorSqueak;
                    doorSource.Play();
                }
                isTriggered = true;
            }
        }
    }
    private void OnTriggerExit(Collider collider){
        isTriggered = false;
    }
}
