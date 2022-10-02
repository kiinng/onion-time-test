using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControlStreet : MonoBehaviour
{
    public GameObject puppy, puppyInst, gab, gabInst, angel, angelInst, sammy, sammyInst, red, gameboyRat, tommyTup, tommyTupInst, sevenInst, eight, emiliaInst, christinaInst, freddieInst;
    private SceneHaver theSceneHaver;

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
    private void Start()
    {
        theSceneHaver = FindObjectOfType<SceneHaver>().GetComponent<SceneHaver>();
        if (theSceneHaver.section1 == true)
        {
            StreetSetup1();
        }
        if (theSceneHaver.section1_1 == true)
        {
            StreetSetup1_1();
        }
        if (theSceneHaver.section2 == true)
        {
            StreetSetup2();
        }
        if (theSceneHaver.section3 == true)
        {
            StreetSetup3();
        }
        if (theSceneHaver.section4 == true)
        {
            StreetSetup4();
        }
        if (theSceneHaver.section5 == true)
        {
            StreetSetup5();
        }
    }

    public void StreetSetup1()
    {
        GameObject PartyBackground = (GameObject)Instantiate(Resources.Load("StreetBGState1"));
        puppy.SetActive(true);
    }

    public void StreetSetup1_1()
    {
        GameObject PartyBackground = (GameObject)Instantiate(Resources.Load("StreetBGState1"));

        puppy.SetActive(true);
    }

    public void StreetSetup2()
    {
        GameObject PartyBackground = (GameObject)Instantiate(Resources.Load("StreetBGState1"));
        puppyInst.SetActive(true);
        gabInst.SetActive(true);
        angelInst.SetActive(true);
        sammyInst.SetActive(true);
        red.SetActive(true);
    }

    public void StreetSetup3()
    {
        GameObject PartyBackground = (GameObject)Instantiate(Resources.Load("StreetBGState3"));
        gameboyRat.SetActive(true);
        tommyTupInst.SetActive(true);
        sevenInst.SetActive(true);
        eight.SetActive(true);
    }

    public void StreetSetup4()
    {
        GameObject PartyBackground = (GameObject)Instantiate(Resources.Load("StreetBGState4"));
        emiliaInst.SetActive(true);
        christinaInst.SetActive(true);
        freddieInst.SetActive(true);
        red.SetActive(true);
    }

    public void StreetSetup5()
    {
        GameObject PartyBackground = (GameObject)Instantiate(Resources.Load("StreetBGState5"));
        puppy.SetActive(true);
        sammy.SetActive(true);
        gab.SetActive(true);
        angel.SetActive(true);
        tommyTup.SetActive(true);
        gameboyRat.SetActive(true);
    }

}
