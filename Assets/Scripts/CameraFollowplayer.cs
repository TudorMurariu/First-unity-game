using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowplayer : MonoBehaviour
{
    public Transform player;

    public Vector3 V3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = V3 + player.position;
    }
}
