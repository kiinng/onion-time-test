using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour
{
    public float beatsPerMin;
    public bool hasStarted;
    // Start is called before the first frame update
    void Start()
    {
        beatsPerMin = beatsPerMin / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            if (Input.anyKeyDown)
            {
                hasStarted = true;
            }
        }
        else
        {
            transform.position -= new Vector3(0f, beatsPerMin * Time.deltaTime, 0f);
        }
    }
}
