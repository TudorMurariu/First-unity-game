using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;

    public float Force = 100f;

    public Text HP;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Convert.ToInt32(HP.text) > 0)
        {
            if (Input.GetKey("d"))
            {
                rb.AddForce(Force * Time.deltaTime, 0, 0);
            }
            else if (Input.GetKey("a"))
            {
                rb.AddForce(-Force * Time.deltaTime, 0, 0);
            }
            else if (Input.GetKey("w"))
            {
                rb.AddForce(0, 0, Force * Time.deltaTime);
            }
            else if (Input.GetKey("s"))
            {
                rb.AddForce(0, 0, -Force * Time.deltaTime);
            }
        }

        /// if u fall , ripp
        
        if(rb.position.y < 0)
        {
            HP.text = "0"; 
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
