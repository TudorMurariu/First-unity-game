using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLvel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //+1
    }
}
