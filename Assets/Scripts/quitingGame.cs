using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class quitingGame : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}
