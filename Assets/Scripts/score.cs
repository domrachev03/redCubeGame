using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    
public class score : MonoBehaviour
{

    public Transform player;
    private float startZcoordinate;
    public Text scoreText;
    void Start()
    {
        startZcoordinate = player.position.z;
    }

    void Update()
    {
        scoreText.text = "Score: " + (startZcoordinate - player.position.z).ToString("0");
    }
}
