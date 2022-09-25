using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class SceneControlParty : MonoBehaviour
{
    public GameObject pumpkin, skully, fishJr, freddie, jess, christina;

    private void Awake()
    {
        fishJr.SetActive(false);
        freddie.SetActive(false);
        jess.SetActive(false);
        christina.SetActive(false);
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

    [YarnCommand("Party_Section1_Setup")]
    public void PartySetup1()
    {
    }

    [YarnCommand("Party_Section1_1_Setup")]
    public void PartySetup1_1()
    {
    }

    [YarnCommand("Party_Section2_Setup")]
    public void PartySetup2()
    {
        FishJrOn();
        skully.transform.position = new Vector2(-5.3f, 1.9f);
    }

    [YarnCommand("Party_Section3_Setup")]
    public void PartySetup3()
    {
        FreddieOn();
        FishJrOn();
    }

    [YarnCommand("Party_Section4_Setup")]
    public void PartySetup4()
    {
        
    }

    [YarnCommand("Party_Section5_Setup")]
    public void PartySetup5()
    {
        FishJrOn();
        FreddieOn();
        JessOn();
        ChristinaOn();
    }

}
