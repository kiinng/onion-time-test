using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class SceneControlCafe : MonoBehaviour
{
    public GameObject madeline, freddie, emilia, jess, red, seven, eight;
    public GameObject bgDay, bgNight;
    private SceneHaver theSceneHaver;

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
    private void Start()
    {
        theSceneHaver = FindObjectOfType<SceneHaver>().GetComponent<SceneHaver>();
        if (theSceneHaver.section1 == true)
        {
            CafeSetup1();
        }
        if (theSceneHaver.section1_1 == true)
        {
            CafeSetup1_1();
        }
        if (theSceneHaver.section2 == true)
        {
            CafeSetup2();
        }
        if (theSceneHaver.section3 == true)
        {
            CafeSetup3();
        }
        if (theSceneHaver.section4 == true)
        {
            CafeSetup4();
        }
        if (theSceneHaver.section5 == true && theSceneHaver.emiliaDate == true)
        {
            CafeSetup5A();
        }
        if (theSceneHaver.section5 == true && theSceneHaver.emiliaDate == false)
        {
            CafeSetup5B();
        }
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

    public void CafeSetup1()
    {
        MadelineOn();
    }

    public void CafeSetup1_1()
    {
        MadelineOn();
    }

    public void CafeSetup2()
    {
        MadelineOn();
        FreddieOn();
    }

    public void CafeSetup3()
    {
        MadelineOn();
        EmiliaOn();
        JessOn();
    }

    public void CafeSetup4()
    {
        MadelineOn();
        bgDay.SetActive(false);
        bgNight.SetActive(true);
    }

    public void CafeSetup5A()
    {
        MadelineOn();
        SevenOn();
        EightOn();
        RedOn();
        bgDay.SetActive(false);
        bgNight.SetActive(true);

    }

    public void CafeSetup5B()
    {
        MadelineOn();
        SevenOn();
        EightOn();
        RedOn();
        EmiliaOn();
        bgDay.SetActive(false);
        bgNight.SetActive(true);

    }
}
