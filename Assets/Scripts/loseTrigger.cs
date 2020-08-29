using UnityEngine.SceneManagement;
using UnityEngine;

public class loseTrigger : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
