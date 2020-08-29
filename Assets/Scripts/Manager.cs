using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    private bool isGameEnded = false;
    public float pauseTime = 3;
    public GameObject winLevelUI;
    public GameObject loseLevelUI;
    public GameObject tutorialUI = null;
    private void Restart()
    {
        SceneManager.LoadScene("scene1");
    }

    public void GameOver()
    {
        if(isGameEnded == false)
        {
            isGameEnded = true;
            if (tutorialUI != null) tutorialUI.SetActive(false);
            Debug.Log("GAME OVER");
            loseLevelUI.SetActive(true);
        }
    }
    
    public void WinGame()
    {
        Debug.Log("YOU WIN!");
        winLevelUI.SetActive(true);
    }
}
