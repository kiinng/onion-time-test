using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class SceneCheck1 : MonoBehaviour
{
    [SerializeField] private string sceneCheckNode;
    private DialogueRunner dialogueRunner;
    // Start is called before the first frame update
    public void Start()
    {
        dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
        dialogueRunner.StartDialogue(sceneCheckNode);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
