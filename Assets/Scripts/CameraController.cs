using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Transform farBackground, midBackground;
    //private float lastXPos;
    private Vector2 lastCameraPos;

    public float minHeight, maxHeight;
    public float minX, maxX;
    
    void Start()
    {
        //lastXPos = transform.position.x;
        //I thought i needed to do a new Vector2(transform.position.x, transform.position.y) but apparently Unity takes off the z axis automatically
        lastCameraPos = transform.position;
    }

    
    void Update()
    {
        //camera using tranform position of target, Y and X axis of camera is clamped
        transform.position = new Vector3(Mathf.Clamp(target.position.x, minX, maxX), Mathf.Clamp(target.position.y, minHeight, maxHeight), transform.position.z);
       
        Vector2 amountToMove = new Vector2(transform.position.x - lastCameraPos.x, transform.position.y - lastCameraPos.y);

        //the bigger the multiplier on amountToMoxe, the more the layer will follow the camera, and therefore LOOK like it's further in the background
        //smaller multipliers move a layer less, so they look closer to the FG platforms
        farBackground.position = farBackground.position + new Vector3(amountToMove.x * .5f, amountToMove.y * .5f, 0f);
        midBackground.position = midBackground.position + new Vector3(amountToMove.x * .1f, amountToMove.y * .1f, 0f);
        //can also write as midBackground.position += new Vector3(amountToMoveX * .1f, 0f, 0f);

        lastCameraPos = transform.position;
    }
}
