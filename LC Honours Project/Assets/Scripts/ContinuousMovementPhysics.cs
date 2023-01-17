using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ContinuousMovementPhysics : MonoBehaviour
{
    public float speed = 1f; //move speed
    public float turnSpeed = 60;

    public float jumpVelocity = 7;

    public InputActionProperty moveInputSource; //input to move
    public InputActionProperty turnInputSource;
    public Rigidbody rb;

    public Transform turnSource;

    public LayerMask groundLayer;

    public Transform directSource; //which direction to move

    private Vector2 inputMoveAxis;
    private float inputTurnAxis;

    private bool isGrounded;

    public CapsuleCollider bodyCollider;

    public InputActionProperty jumpInputSource;




    void Update(){
       inputMoveAxis = moveInputSource.action.ReadValue<Vector2>();
       inputTurnAxis = turnInputSource.action.ReadValue<Vector2>().x;

       bool jumpInput = jumpInputSource.action.WasPerformedThisFrame();

       if(jumpInput && isGrounded){
        rb.velocity = Vector3.up * jumpVelocity;
       }
    }

    public void FixedUpdate(){
        isGrounded = CheckIfGrounded();

        if (isGrounded){
            Quaternion yaw = Quaternion.Euler(0, directSource.eulerAngles.y, 0);
            Vector3 direction = yaw * new Vector3(inputMoveAxis.x, 0, inputMoveAxis.y);

            Vector3 targetMovePostion = rb.position + direction * Time.fixedDeltaTime * speed;

            Vector3 axis = Vector3.up;
            float angle = turnSpeed * Time.fixedDeltaTime * inputTurnAxis;
            Quaternion q = Quaternion.AngleAxis(angle, axis);

            rb.MoveRotation(rb.rotation * q);

            Vector3 newPostion = q * (targetMovePostion-turnSource.position) + turnSource.position;

            rb.MovePosition(newPostion);
        }

       
    }

    public bool CheckIfGrounded(){
        Vector3 start = bodyCollider.transform.TransformPoint(bodyCollider.center);
        float rayLength = bodyCollider.height/2 - bodyCollider.radius + 0.05f;

        bool hasHit = Physics.SphereCast(start, bodyCollider.radius, Vector3.down, out RaycastHit hitInfo, rayLength, groundLayer);

        return hasHit;
    }

}
