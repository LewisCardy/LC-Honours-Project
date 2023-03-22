using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverInsert : MonoBehaviour
{
    public GameObject lever;
    public GameObject moveableLever;
    public AudioClip leverInsert;
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider collider){
        if(collider.tag == "Lever"){
            moveableLever.SetActive(true);
            collider.gameObject.SetActive(false);
            audioSource.clip = leverInsert;
            audioSource.Play();
        }
    }
}
