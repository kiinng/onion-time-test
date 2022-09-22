using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueRunnerExtras : MonoBehaviour
{
    public void DisablePlayerControl()
    {
        FindObjectOfType<PlayerController>().enabled = false;
    }
    public void EnablePlayerControl()
    {
        FindObjectOfType<PlayerController>().enabled = true;
    }
}
