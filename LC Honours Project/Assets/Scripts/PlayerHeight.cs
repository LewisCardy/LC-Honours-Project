using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeight : MonoBehaviour
{
    public Transform head;

    public CharacterController playerController;
    public float bodyHeightMin = 0.5f;
    public float bodyHeightMax = 2;

    void FixedUpdate(){
        playerController.height = Mathf.Clamp(head.localPosition.y, bodyHeightMin, bodyHeightMax);
    
    }
}
