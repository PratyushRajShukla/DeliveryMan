using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1);
    
    [SerializeField] float destroyDelay;
    
    bool hasPackage;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Fuck!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Debug.Log("Welcome To The Shit Zone!!");

        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package Picked Up BITCH!!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject,destroyDelay);
            
        }

        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered Bitch!");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
        
    }
}
