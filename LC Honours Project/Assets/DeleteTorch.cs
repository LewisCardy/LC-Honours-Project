using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteTorch : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider){
        Debug.Log("Triggered");
        if (collider.tag == "Torch"){
            collider.gameObject.SetActive(false);
        }
    }
}
