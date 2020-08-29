using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialScript : MonoBehaviour
{

    public GameObject tutorial;
    public GameObject score;
    // Start is called before the first frame update
    public void EndOfTutorial()
    {
        tutorial.SetActive(false);
        score.SetActive(true);
    }
}
