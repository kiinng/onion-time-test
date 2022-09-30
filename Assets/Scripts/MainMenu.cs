using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string startScene;
    public GameObject controlMenu;
    public GameObject creditMenu;

    // Start is called before the first frame update
    void Start()
    {
        controlMenu.SetActive(false);
        creditMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        Destroy(FindObjectOfType<DontDestroyBit>());
        SceneManager.LoadScene(startScene);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("quitting game");
    }

    public void ControlsWindowShow()
    {
        if (creditMenu != null)
        {
            creditMenu.SetActive(false);

        }
        if(controlMenu != null && controlMenu.activeInHierarchy == true)
        {
            controlMenu.SetActive(false);

        }
        else
        {
            controlMenu.SetActive(true);
        }
       
    }
    public void CreditsWindowShow()
    {
        if (controlMenu != null)
        {
            controlMenu.SetActive(false);

        }
        controlMenu.SetActive(false);
        if (creditMenu != null && creditMenu.activeInHierarchy == true)
        {
            creditMenu.SetActive(false);

        }
        else
        {
            creditMenu.SetActive(true);
        }
    }

    public void CreditsWindowHide()
    {
        creditMenu.SetActive(false);

    }
    public void ControlsWindowHide()
    {
        controlMenu.SetActive(false);
    }
}
