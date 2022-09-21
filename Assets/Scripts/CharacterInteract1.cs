using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInteract1 : MonoBehaviour
{
    public SpriteRenderer talkIndicator;
    public bool canTalk;
    public YarnInteractable yarnInteract;
    // Start is called before the first frame update
    void Start()
    {
        canTalk = false;
        talkIndicator.enabled = false;
        yarnInteract = GetComponent<YarnInteractable>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            if(canTalk == true)
            {
                yarnInteract.OnMouseDown();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            canTalk = true;
            talkIndicator.enabled = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            canTalk = false;
            talkIndicator.enabled = false;
        }
    }
}
