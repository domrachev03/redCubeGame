using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    public Movement movement;

    void OnCollisionEnter(UnityEngine.Collision colInfo)
    {
        if (colInfo.gameObject.tag == "Obstacle")
        {
            movement.forwardForce = 0;
            movement.turnForce = 0;
            FindObjectOfType<Manager>().GameOver();
        }
    }
}
