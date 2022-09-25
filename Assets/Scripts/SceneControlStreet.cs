using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class SceneControlStreet : MonoBehaviour
{
    public GameObject puppy, puppyInst, gab, gabInst, angel, angelInst, sammy, sammyInst, red, gameboyRat, tommyTup, tommyTupInst, sevenInst, eight, emiliaInst, christinaInst, freddieInst;

    private void Awake()
    {
        puppy.SetActive(false);
        puppyInst.SetActive(false);
        gab.SetActive(false);
        gabInst.SetActive(false);
        angel.SetActive(false);
        angelInst.SetActive(false);
        sammy.SetActive(false);
        sammyInst.SetActive(false);
        red.SetActive(false);
        gameboyRat.SetActive(false);
        tommyTup.SetActive(false);
        tommyTupInst.SetActive(false);
        sevenInst.SetActive(false);
        eight.SetActive(false);
        emiliaInst.SetActive(false);
        christinaInst.SetActive(false);
        freddieInst.SetActive(false);
    }

    [YarnCommand("Street_Section1_Setup")]
    public void StreetSetup1()
    {
        puppy.SetActive(true);
    }

    [YarnCommand("Street_Section1_1_Setup")]
    public void StreetSetup1_1()
    {
        puppy.SetActive(true);
    }

    [YarnCommand("Street_Section2_Setup")]
    public void StreetSetup2()
    {
        puppyInst.SetActive(true);
        gabInst.SetActive(true);
        angelInst.SetActive(true);
        sammyInst.SetActive(true);
        red.SetActive(true);
    }

    [YarnCommand("Street_Section3_Setup")]
    public void StreetSetup3()
    {
        gameboyRat.SetActive(true);
        tommyTupInst.SetActive(true);
        sevenInst.SetActive(true);
        eight.SetActive(true);
    }

    [YarnCommand("Street_Section4_Setup")]
    public void StreetSetup4()
    {
        emiliaInst.SetActive(true);
        christinaInst.SetActive(true);
        freddieInst.SetActive(true);
        red.SetActive(true);
    }

    [YarnCommand("Street_Section5_Setup")]
    public void StreetSetup5()
    {
        puppy.SetActive(true);
        sammy.SetActive(true);
        gab.SetActive(true);
        angel.SetActive(true);
        tommyTup.SetActive(true);
        gameboyRat.SetActive(true);
    }

}
