using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTeleport : MonoBehaviour
{
    public DoorTeleport targetDoor;
    public PlayerController thePlayer;
    public bool canEnter;
    public SpriteRenderer doorIndicator;
    // Start is called before the first frame update
    void Start()
    {
        doorIndicator.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            if(canEnter == true)
            {
                thePlayer.transform.position = targetDoor.transform.position;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            canEnter = true;
            doorIndicator.enabled = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            canEnter = false;
            doorIndicator.enabled = false;
        }
    }
}
