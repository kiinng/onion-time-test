using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    public PlayerController thePlayer;
    private Vector3 spawnPoint;
    void Start()
    {
        spawnPoint = thePlayer.transform.position;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            //Debug.Log("hit");
            thePlayer.myRigidbody.velocity = new Vector2(0, 0);
            thePlayer.transform.position = spawnPoint;
        }
    }
}
