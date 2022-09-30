using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControlParty : MonoBehaviour
{
    public GameObject pumpkin, skully, fishJr, freddie, jess, christina;
    private SceneHaver theSceneHaver;

    private void Awake()
    {
        fishJr.SetActive(false);
        freddie.SetActive(false);
        jess.SetActive(false);
        christina.SetActive(false);
    }

    private void Start()
    {
        theSceneHaver = FindObjectOfType<SceneHaver>().GetComponent<SceneHaver>();
        if (theSceneHaver.section1 == true)
        {
            PartySetup1();
        }
        if (theSceneHaver.section1_1 == true)
        {
            PartySetup1_1();
        }
        if (theSceneHaver.section2 == true)
        {
            PartySetup2();
        }
        if (theSceneHaver.section3 == true)
        {
            PartySetup3();
        }
        if (theSceneHaver.section4 == true)
        {
            PartySetup4();
        }
        if (theSceneHaver.section5 == true)
        {
            PartySetup5();
        }
    }

    public void FishJrOn()
    {
        fishJr.SetActive(true);
    }
    public void FreddieOn()
    {
        freddie.SetActive(true);
    }
    public void JessOn()
    {
        jess.SetActive(true);
    }
    public void ChristinaOn()
    {
        christina.SetActive(true);
    }

    public void PartySetup1()
    {
    }

    public void PartySetup1_1()
    {
    }

    public void PartySetup2()
    {
        FishJrOn();
        skully.transform.position = new Vector2(-5.3f, 1.9f);
    }

    public void PartySetup3()
    {
        FreddieOn();
        FishJrOn();
    }


    public void PartySetup4()
    {
        
    }

    public void PartySetup5()
    {
        FishJrOn();
        FreddieOn();
        JessOn();
        ChristinaOn();
    }

}
