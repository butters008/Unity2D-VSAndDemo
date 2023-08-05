using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileCarCollision : MonoBehaviour
{
    //Should handle collision outside of Car Script, but O well.
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Finish"))
        {
            // score++;
            // Debug.Log(score);
            Debug.Log("Finish Line Triggered");
        }
        else if (other.CompareTag("Player"))
        {
            Debug.Log("My Logic is Off....");
        }
        else if (other.CompareTag("PleaseWork"))
        {
            Debug.Log("Really??");
        }
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ouch"))
        {
            Debug.Log("Ouch");
        }
        else if (other.gameObject.CompareTag("PleaseWork"))
        {
            Debug.Log("Something is wrong!!!");
        }
        else
        {
            Debug.Log("Something is wrong");
        }
    }
}
