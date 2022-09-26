using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class YarnFunctions1 : MonoBehaviour
{
    public GameObject prefabToSpawn;
    //gotta load the cafe scene after the dummy intro scene where you get the dialogue runner open
    [YarnCommand("load_cafe")]
    public static void LoadCafe()
    {
        SceneManager.LoadScene("LocationCafe");
    }

    [YarnCommand("load_street")]
    public static void LoadStreet()
    {
        SceneManager.LoadScene("LocationStreet");
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

    //instantiate PhoneChatPrefab (only used for intro conversation)
    [YarnCommand("text_rats_on")]
    public static void LoadPhoneConvo()
    {
        GameObject newConvo = (GameObject)Instantiate(Resources.Load("PhoneChatPrefab"));
    }

    //destroy PhoneChatPrefab (only used for intro conversation)
    [YarnCommand("text_rats_off")]
    public static void DestroyPhoneConvo()
    {
        Destroy(GameObject.Find("PhoneChatPrefab(Clone)"));
    }
}
