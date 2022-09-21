using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFallThrough : MonoBehaviour
{
    private BoxCollider2D myBoxCollider;
    public float fallWaitTime;

    void Start()
    {
        myBoxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Vertical") && Input.GetAxisRaw("Vertical") < 0)
        {
            StartCoroutine(FallWaitTime());
        }
    }

    IEnumerator FallWaitTime()
    {
        myBoxCollider.enabled = false;
        yield return new WaitForSeconds(fallWaitTime);
        myBoxCollider.enabled = true;
    }
}
