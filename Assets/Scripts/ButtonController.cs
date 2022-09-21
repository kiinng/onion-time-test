using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private SpriteRenderer mySpriteRend;
    //public Sprite defaultImage;
    //public Sprite pressedImage;
    public Color defaultCol, pressedCol = new Color(0f, 0f, 0f);


    public KeyCode keyToPress;
    // Start is called before the first frame update
    void Start()
    {
        mySpriteRend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToPress))
        {
            //mySpriteRend.sprite = pressedImage;
            mySpriteRend.color = pressedCol;
        }
        if (Input.GetKeyUp(keyToPress))
        {
            //mySpriteRend.sprite = defaultImage;
            mySpriteRend.color = defaultCol;
        }
    }
}
