using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollectable : MonoBehaviour
{
    private GameObject gameManagerObj;
    private GameManager gameManager;
    public AudioSource audioSource;
    void Update(){ //rotates the key
        gameObject.transform.Rotate(0f, 0.7f, 0f, Space.Self);
    }
    void Start(){
        gameManagerObj = GameObject.Find("GameManager"); //find the game manager object
        gameManager = gameManagerObj.GetComponent<GameManager>(); //get the game manager script
    }

    private void OnTriggerEnter(Collider other){ //when the player collects the key
        audioSource.Play(); //play collection sound
        gameManager.CollectKey(); //collect key in game manager
        gameObject.SetActive(false); //de activate key
        
        
    }
}
