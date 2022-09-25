using UnityEngine;
using Yarn.Unity;

public class SceneControlPark : MonoBehaviour
{
    public GameObject emilia;
    public GameObject sasha1;
    public GameObject sasha2;

    private void Awake()
    {
        emilia.SetActive(false);
        sasha1.SetActive(false);
        sasha2.SetActive(false);
    }

    public void EmiliaOn()
    {
        emilia.SetActive(true);
    }
    public void Sasha1On()
    {
        sasha1.SetActive(true);
    }
    public void Sasha2On()
    {
        sasha2.SetActive(true);
    }

    [YarnCommand("Park_Section1_Setup")]
    public void ParkSetup1()
    {
    }

    [YarnCommand("Park_Section1_1_Setup")]
    public void ParkSetup1_1()
    {
    }

    [YarnCommand("Park_Section2_Setup")]
    public void ParkSetup2()
    {
        Sasha1On();
    }

    [YarnCommand("Park_Section3_Setup")]
    public void ParkSetup3()
    {
        Sasha1On();
    }

    [YarnCommand("Park_Section4_Setup")]
    public void ParkSetup4()
    {
        Sasha1On();
    }

    [YarnCommand("Park_Section5a_Setup")]
    public void ParkSetup5A()
    {
        Sasha1On();
    }

    [YarnCommand("Park_Section5b_Setup")]
    public void ParkSetup5B()
    {
        Sasha2On();
        EmiliaOn();
    }
}
