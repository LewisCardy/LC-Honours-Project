using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterScript : MonoBehaviour
{
    private GameObject gameManagerObj;
    private GameManager gameManager;
    public AudioSource growl;
    public GameObject trigger;
    public void activateMonster(){
        gameObject.SetActive(true);
        growl.Play();
        trigger.SetActive(false);
        Debug.Log("Activated");
        StartCoroutine(endGame());
    }

    void Update(){
        gameManagerObj = GameObject.Find("GameManager"); //find the game manager object
        gameManager = gameManagerObj.GetComponent<GameManager>(); //get the game manager script
    }

    IEnumerator endGame(){
        yield return new WaitForSeconds(10);
        gameManager.LoadScene("Credits Scene");
    }
}
