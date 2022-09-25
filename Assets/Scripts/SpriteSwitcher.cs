using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class SpriteSwitcher : MonoBehaviour
{
    public Sprite sprite1, sprite2;
    public SpriteRenderer mySpriteRenderer;

    [YarnCommand("ShowSprite1")]
    public void ShowSprite1()
    {
        mySpriteRenderer.sprite = sprite1;
    }

    [YarnCommand("ShowSprite2")]
    public void ShowSprite2()
    {
        mySpriteRenderer.sprite = sprite2;
    }
}
