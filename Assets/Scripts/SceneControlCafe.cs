using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class SceneControlCafe : MonoBehaviour
{
    public GameObject madeline, freddie, emilia, jess, red, seven, eight;


    private void Awake()
    {
        //madeline.SetActive(false);
        freddie.SetActive(false);
        emilia.SetActive(false);
        jess.SetActive(false);
        red.SetActive(false);
        seven.SetActive(false);
        eight.SetActive(false);
    }

    public void MadelineOn()
    {
        madeline.SetActive(true);
    }
    public void FreddieOn()
    {
        freddie.SetActive(true);
    }
    public void EmiliaOn()
    {
        emilia.SetActive(true);
    }
    public void JessOn()
    {
        jess.SetActive(true);
    }
    public void RedOn()
    {
        red.SetActive(true);
    }
    public void SevenOn()
    {
        seven.SetActive(true);
    }
    public void EightOn()
    {
        eight.SetActive(true);
    }

    [YarnCommand("Cafe_Section1_Setup")]
    public void CafeSetup1()
    {
        MadelineOn();
    }

    [YarnCommand("Cafe_Section1_1_Setup")]
    public void CafeSetup1_1()
    {
        MadelineOn();
    }

    [YarnCommand("Cafe_Section2_Setup")]
    public void CafeSetup2()
    {
        MadelineOn();
        FreddieOn();
    }

    [YarnCommand("Cafe_Section3_Setup")]
    public void CafeSetup3()
    {
        MadelineOn();
        EmiliaOn();
        JessOn();
    }

    [YarnCommand("Cafe_Section4_Setup")]
    public void CafeSetup4()
    {
        MadelineOn();
    }

    [YarnCommand("Cafe_Section5a_Setup")]
    public void CafeSetup5A()
    {
        MadelineOn();
        SevenOn();
        EightOn();
        RedOn();
    }

    [YarnCommand("Cafe_Section5b_Setup")]
    public void CafeSetup5B()
    {
        MadelineOn();
        SevenOn();
        EightOn();
        RedOn();
        EmiliaOn();
    }
}
