using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScene : MonoBehaviour
{
    public string goToScene;
    public bool canEnter;
    public SpriteRenderer doorIndicator;
    public bool usePosition;
    public Vector2 newPosition = new Vector3(0,1,0);
    private PlayerController playerSpawn;


   
    void Start()
    {
        doorIndicator.enabled = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if(canEnter == true)
            {
                if(usePosition == true)
                {
                    SceneManager.sceneLoaded += OnSceneLoaded;
                }
                SceneManager.LoadScene(goToScene);
                Debug.Log("key pressed");
                

            }
        }
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        playerSpawn = FindObjectOfType<PlayerController>();
        playerSpawn.transform.position = newPosition;
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            canEnter = true;
            doorIndicator.enabled = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            canEnter = false;
            doorIndicator.enabled = false;
        }
    }
}
