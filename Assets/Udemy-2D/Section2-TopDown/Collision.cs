using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    bool hasPackage = false;
    [SerializeField] Color32 hasPackageColor = new Color32();
    [SerializeField] Color32 noPackageColor = new Color32();
    SpriteRenderer spriteRenderer;


    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("doing something!");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("This is the trigger! Woot Woot!");
        if(other.tag == "Package" && hasPackage == true){
            Debug.Log("Packages delievered");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
            Destroy(other.gameObject, 2);
            
        }
        else{
            Debug.Log("Where is it?");
        }
        if(other.tag == "Ouch"){
            Debug.Log("Ouch Silly!");
        }
        if(other.tag == "DaBox"){
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, 3);
        }

    }
}
