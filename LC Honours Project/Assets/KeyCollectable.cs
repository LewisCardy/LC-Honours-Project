using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollectable : MonoBehaviour
{
    void Update(){
        gameObject.transform.Rotate(0f, 0.7f, 0f, Space.Self);
    }

    private void OnTriggerEnter(Collider other){
        gameObject.SetActive(false);
    }
}
