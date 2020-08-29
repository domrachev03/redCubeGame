using UnityEngine.SceneManagement;
using UnityEngine;

public class mainWindowManager : MonoBehaviour
{
    public void StartGame()
    {  
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}
