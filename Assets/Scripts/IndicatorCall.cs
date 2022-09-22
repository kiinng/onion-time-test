using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorCall : MonoBehaviour
{
    public SpriteRenderer theIndicator;
    // Start is called before the first frame update
    void Awake()
    {
        theIndicator = GetComponent<SpriteRenderer>();
        theIndicator.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
