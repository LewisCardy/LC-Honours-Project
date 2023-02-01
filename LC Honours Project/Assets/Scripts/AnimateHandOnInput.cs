using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;
    public InputActionProperty gripAnimationAction;

    public Animator handAnimator;

    public bool isLeft;
    public bool isRight;
    public bool isFloating;
    void Update()
    {
        if(isLeft){
            float leftTriggerValue = pinchAnimationAction.action.ReadValue<float>();
            handAnimator.SetFloat("LeftTrigger", leftTriggerValue);

            float leftGripValue = gripAnimationAction.action.ReadValue<float>();
            handAnimator.SetFloat("LeftGrip", leftGripValue);
        } else if(isRight){
            float rightTriggerValue = pinchAnimationAction.action.ReadValue<float>();
            handAnimator.SetFloat("RightTrigger", rightTriggerValue);

            float rightGripValue = gripAnimationAction.action.ReadValue<float>();
            handAnimator.SetFloat("RightGrip", rightGripValue);
        } else if (isFloating){
            float triggerValue = pinchAnimationAction.action.ReadValue<float>();
            handAnimator.SetFloat("Trigger", triggerValue);

            float gripValue = gripAnimationAction.action.ReadValue<float>();
            handAnimator.SetFloat("Grip", gripValue);
        }
    }
}
