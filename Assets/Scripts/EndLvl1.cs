using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLvl1 : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
