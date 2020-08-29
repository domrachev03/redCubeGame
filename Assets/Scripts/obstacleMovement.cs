using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class obstacleMovement : MonoBehaviour
{
    public float speed = 10;
    public float leftEdge = -7, rightEdge = 7;
    public Rigidbody rb;
    public bool isGoingRight = true;

    // Update is called once per frame
    void Update()
    {
        if (isGoingRight == true)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;

            if (rb.position.x > rightEdge)
            {
                isGoingRight = false;
            }
        }
        else
        {
            transform.position += -Vector3.right * speed * Time.deltaTime;

            if (rb.position.x < leftEdge)
            {
                isGoingRight = true;
            }
        }
    }
}
