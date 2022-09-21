using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnFunctions1 : MonoBehaviour
{
   
    [YarnCommand("disable_playercontrol")]
    public static void DisablePlayer()
    {
        FindObjectOfType<PlayerController>().enabled = false;
    }

    [YarnCommand("enable_playercontrol")]
    public static void EnablePlayer()
    {
        FindObjectOfType<PlayerController>().enabled = true;
    }
}
