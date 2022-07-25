using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CollisionScript : MonoBehaviour
{
    public Material material;

    public Text HP; 

    void OnCollisionEnter(Collision C)
    {
        if(C.collider.tag == "Obstacle" && Convert.ToInt32(HP.text) > 0)
        {
            material.color = Color.red;
            HP.text = (Convert.ToInt32(HP.text) - 20).ToString();
        }
        if(Convert.ToInt32(HP.text) <= 0)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        //Debug.Log(C.collider.name);
    }

    void OnCollisionExit()
    {
        material.color = Color.white;
    }
}
