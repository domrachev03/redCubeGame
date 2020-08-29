using UnityEngine.SceneManagement;
using UnityEngine;

public class completeTrigger : MonoBehaviour
{
    void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
