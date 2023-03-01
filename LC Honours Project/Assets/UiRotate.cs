using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiRotate : MonoBehaviour
{
    public float rotateSpeed = 0.7f;
    void Update()
    {
        gameObject.transform.Rotate(0f, rotateSpeed, 0f, Space.Self);
    }
}
