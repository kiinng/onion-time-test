using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerIndicator : MonoBehaviour
{
    public SpriteRenderer indicator;
  
    public void Start()
    {
        indicator.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            indicator.enabled = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            indicator.enabled = false;
        }
    }
}
