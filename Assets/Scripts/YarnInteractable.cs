using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnInteractable : MonoBehaviour {
    // internal properties exposed to editor
    [SerializeField] private string conversationStartNode;

    public bool canTalk;

    // internal properties not exposed to editor
    private DialogueRunner dialogueRunner;
    //private Light lightIndicatorObject = null;
    private bool interactable = true;
    private bool isCurrentConversation = false;
    private float defaultIndicatorIntensity;
    

    public void Start()
    {
        canTalk = false;
        dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
        dialogueRunner.onDialogueComplete.AddListener(EndConversation);
        //lightIndicatorObject = GetComponentInChildren<Light>();
        // get starter intensity of light then
        // if we're using it as an indicator => hide it 
        //if (lightIndicatorObject != null) {
            //defaultIndicatorIntensity = lightIndicatorObject.intensity;
            //lightIndicatorObject.intensity = 0;
        //}
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (interactable && !dialogueRunner.IsDialogueRunning && canTalk)
            {
                StartConversation();
            }
        }
    }

    private void StartConversation() {
        Debug.Log($"Started conversation with {name}.");
        isCurrentConversation = true;
        // if (lightIndicatorObject != null) {
        //     lightIndicatorObject.intensity = defaultIndicatorIntensity;
        // }
        dialogueRunner.StartDialogue(conversationStartNode);
        FindObjectOfType<PlayerController>().GetComponent<PlayerController>().enabled = false;
    }

    private void EndConversation() {
        if (isCurrentConversation) {
            // if (lightIndicatorObject != null) {
            //     lightIndicatorObject.intensity = 0;
            // }
            FindObjectOfType<PlayerController>().GetComponent<PlayerController>().enabled = true;
            isCurrentConversation = false;
            Debug.Log($"Ended conversation with {name}.");
        }
    }

//    [YarnCommand("disable")]
    public void DisableConversation() {
        interactable = false;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //canTalk true when Player enters trigger area, talk indicator turned on
        if (other.tag == "Player")
        {
            canTalk = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        //canTalk false when Player exits trigger area, talk indicator turned ff
        if (other.tag == "Player")
        {
            canTalk = false;
        }
    }
}