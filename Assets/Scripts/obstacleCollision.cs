using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleCollision : MonoBehaviour
{
    public obstacleMovement movement;

    private void OnCollisionEnter(UnityEngine.Collision col)
    {
        if(col.gameObject.tag == "Obstacle")
        {
            movement.isGoingRight = !movement.isGoingRight;
        }
        if(col.gameObject.tag == "Player")
        {
            movement.enabled = false;
        }
    }
}
