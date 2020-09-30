using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 30f;
    public float fastSpeed = 40f;

    private Rigidbody rBody;
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        var horAxis = Input.GetAxis("Horizontal");
        var vertAxis = Input.GetAxis("Vertical");
        
        var movement = Time.fixedDeltaTime * moveSpeed * new Vector3(horAxis, 0, vertAxis);
        
        rBody.MovePosition(transform.position + movement);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = fastSpeed;
        }
        else
        {
            moveSpeed = 15f;
        }
    }
}
