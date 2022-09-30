using UnityEngine;

public class SceneControlPark : MonoBehaviour
{
    public GameObject emilia;
    public GameObject sasha1;
    public GameObject sasha2;

    private SceneHaver theSceneHaver;

    private void Awake()
    {
        emilia.SetActive(false);
        sasha1.SetActive(false);
        sasha2.SetActive(false);
    }
    private void Start()
    {
        theSceneHaver = FindObjectOfType<SceneHaver>().GetComponent<SceneHaver>();
        if(theSceneHaver.section1 == true)
        {
            ParkSetup1();
        }
        if (theSceneHaver.section1_1 == true)
        {
            ParkSetup1_1();
        }
        if (theSceneHaver.section2 == true)
        {
            ParkSetup2();
        }
        if (theSceneHaver.section3 == true)
        {
            ParkSetup3();
        }
        if (theSceneHaver.section4 == true)
        {
            ParkSetup4();
        }
        if (theSceneHaver.section5 == true && theSceneHaver.emiliaDate == false)
        {
            ParkSetup5A();
        }
        if (theSceneHaver.section5 == true && theSceneHaver.emiliaDate == true)
        {
            ParkSetup5B();
        }
    }


   
    public void ParkSetup1()
    {
    }

    public void ParkSetup1_1()
    {
    }

    public void ParkSetup2()
    {
        sasha1.SetActive(true);
    }

    public void ParkSetup3()
    {
        sasha1.SetActive(true);
    }

    public void ParkSetup4()
    {
        sasha1.SetActive(true);
    }

    public void ParkSetup5A()
    {
        sasha1.SetActive(true);
    }

    public void ParkSetup5B()
    {
        sasha2.SetActive(true);
        emilia.SetActive(true);
    }
}
