using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class VelocityContainer : MonoBehaviour
{
    [SerializeField] private InputActionProperty velocityInput;

    public Vector3 velocity => velocityInput.action.ReadValue<Vector3>();
} 
