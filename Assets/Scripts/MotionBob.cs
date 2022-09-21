using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionBob : MonoBehaviour
{
    public float bobRangeY = 1f;
    public float bobSpeed = 1f;
    private Transform myTransform;
    private Vector2 initialPos;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = gameObject.GetComponent<Transform>();
        initialPos = new Vector2(myTransform.position.x, myTransform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.position = new Vector2(initialPos.x, initialPos.y + bobRangeY * (Mathf.Sin(Time.time * bobSpeed)));
    }
}
