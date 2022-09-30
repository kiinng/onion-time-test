using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeypressContinue : MonoBehaviour
{
    public Button continueButton;

    private void Awake()
    {
        continueButton = GetComponent<Button>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            continueButton.onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            continueButton.onClick.Invoke();
        }
    }
}
