using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//SCRIPT DEFUNCT DELETE LATER
//UNITY XR HAS THIS BUILT IN WITH THE CHARACTER CONTROLLER DRIVER

public class PlayerHeight : MonoBehaviour
{
    public Transform head;

    public CharacterController playerController;
    public float bodyHeightMin = 0.5f;
    public float bodyHeightMax = 2;
    public float bodyHeightOffset = 1f;

    void FixedUpdate(){
        playerController.height = Mathf.Clamp(head.localPosition.y+bodyHeightOffset, bodyHeightMin, bodyHeightMax);
    
    }
}
