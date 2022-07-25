using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour
{
    public Transform player;

    public Text scoreText;
    void Update()
    {
        if((player.position.z / 10 + 1) >= 0)
            scoreText.text = (player.position.z /10 + 1).ToString("0");
    }
}
