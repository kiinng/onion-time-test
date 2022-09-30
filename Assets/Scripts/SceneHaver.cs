using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class SceneHaver : MonoBehaviour
{
    //stick this script on the dialogue system, which has DontDestroyOnLoad
    //so this script will carry the section variables the whole game
    public bool section1, section1_1, section2, section3, section4, section5, emiliaDate = false;


    //call command in Yarn with <<section1_on DialogueSystem1>>
    //or whatever the gameobject is called
    //also Yarn will NOT be able to access a command on a gameobject with spaces in its name
    [YarnCommand("section1_on")]
    public void Section1On()
    {
        section1 = true;
    }

    [YarnCommand("section1_off")]
    public void Section1Off()
    {
        section1 = false;
    }

    [YarnCommand("section1_1_on")]
    public void Section1_1On()
    {
        section1_1 = true;
    }

    [YarnCommand("section1_1_off")]
    public void Section1_1Off()
    {
        section1_1 = false;
    }

    [YarnCommand("section2_on")]
    public void Section2On()
    {
        section2 = true;
    }

    [YarnCommand("section2_off")]
    public void Section2Off()
    {
        section2 = false;
    }

    [YarnCommand("section3_on")]
    public void Section3On()
    {
        section3 = true;
    }

    [YarnCommand("section3_off")]
    public void Section3Off()
    {
        section3 = false;
    }
    [YarnCommand("section4_on")]
    public void Section4On()
    {
        section4 = true;
    }

    [YarnCommand("section4_off")]
    public void Section4Off()
    {
        section4 = false;
    }

    [YarnCommand("section5_on")]
    public void Section5On()
    {
        section5 = true;
    }

    [YarnCommand("section5_off")]
    public void Section5Off()
    {
        section5 = false;
    }

    [YarnCommand("emiliaDate_on")]
    public void EmiliaDateOn()
    {
        emiliaDate = true;
    }

    [YarnCommand("emiliaDate_off")]
    public void EmiliaDateOff()
    {
        emiliaDate = false;
    }
}
