using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject completeLVLUI;

    public bool WON = false;
    public void EndGame()
    {
        if(WON != true)
        {
            Debug.Log("U lost :(");
            Invoke("Restart", 1.5f);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        WON = true;
        completeLVLUI.SetActive(true);
        Debug.Log("LVL WON");
    }
}
