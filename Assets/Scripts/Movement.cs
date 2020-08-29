using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Movement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = -100;
    public float turnForce = -5;

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(turnForce * horizontal, 0, forwardForce);
        if (rb.position.x > 7 && movement.x > 0) movement.x = 0;
        if (rb.position.x < -7 && movement.x < 0) movement.x = 0;

        transform.position += movement * Time.deltaTime;
    
    }
}
