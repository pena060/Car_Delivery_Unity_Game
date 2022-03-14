using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] Color32 packagePickupColor;
    [SerializeField] Color32 noPickupColor;
    SpriteRenderer spriteRenderer;

    void Start() {
       spriteRenderer =  GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "package" && !hasPackage){

            spriteRenderer.color = packagePickupColor;
            Destroy(other.gameObject, 0.1f);
            hasPackage = true;

        } else if(other.tag == "customer" && hasPackage){
             spriteRenderer.color = noPickupColor;
             hasPackage = false;
        }
    }
}
