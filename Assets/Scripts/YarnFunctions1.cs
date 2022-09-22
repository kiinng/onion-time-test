using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class YarnFunctions1 : MonoBehaviour
{
    [YarnCommand("load_cafe")]
    public static void LoadCafe()
    {
        SceneManager.LoadScene("LocationCafe");
    }
    //disable and enable player controller, only for intro sections (otherwise YarnInteractable script handles it)
    [YarnCommand("disable_playercontrol")]
    public static void DisablePlayer()
    {
        FindObjectOfType<PlayerController>().GetComponent<PlayerController>().enabled = false;
    }

    [YarnCommand("enable_playercontrol")]
    public static void EnablePlayer()
    {
        FindObjectOfType<PlayerController>().GetComponent<PlayerController>().enabled = true;
    }

    //enable and disable call indicator
    [YarnCommand("call_bubble_on")]
    public static void CallBubbleOn()
    {
        FindObjectOfType<IndicatorCall>().GetComponent<SpriteRenderer>().enabled = true;
    }
    [YarnCommand("call_bubble_off")]
    public static void CallBubbleOff()
    {
        FindObjectOfType<IndicatorCall>().GetComponent<SpriteRenderer>().enabled = false;
    }

}
