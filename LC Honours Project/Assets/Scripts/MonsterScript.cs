using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterScript : MonoBehaviour
{
    public AudioSource growl;
    public GameObject trigger;
    public void activateMonster(){
        gameObject.SetActive(true);
        growl.Play();
        trigger.SetActive(false);
        Debug.Log("Activated");
    }
}
