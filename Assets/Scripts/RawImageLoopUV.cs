using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(RawImage))]
public class RawImageLoopUV : MonoBehaviour
{
    private RawImage img;

    public Vector2 speed;
    // Start is called before the first frame update
    void Awake()
    {
        img = GetComponent<RawImage>();
    }

    // Update is called once per frame
    void Update()
    {
        Rect rect = img.uvRect;
        rect.x += Time.deltaTime * speed.x;
        rect.y += Time.deltaTime * speed.y;
        img.uvRect = rect;
    }
}
