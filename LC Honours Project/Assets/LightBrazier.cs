using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBrazier : MonoBehaviour
{
     public GameObject brazier;

    void Start(){
        
    }

    void OnCollisionEnter(Collision collision){ //if the torch colliders with the brazier
        if(collision.collider.tag == "Brazier"){
            //makes brazier appear lit
            brazier.transform.GetChild(3).gameObject.SetActive(true);
            brazier.transform.GetChild(4).gameObject.SetActive(false);

            //enables the particle and light of the brazier
            brazier.transform.GetChild(6).gameObject.SetActive(true);
            brazier.transform.GetChild(7).gameObject.SetActive(true);
        }
    }
}
