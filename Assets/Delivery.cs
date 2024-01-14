using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
   bool hasPackage;
   [SerializeField] float delay = 0.5f;
   [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
   [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1);
   SpriteRenderer spriteRenderer;

   void Start() {
      spriteRenderer = GetComponent<SpriteRenderer>();
   }

   void OnCollisionEnter2D(Collision2D other)  {
    
   }

   void OnTriggerEnter2D(Collider2D other) {
    if (other.tag == "Package" && !hasPackage) {
      Debug.Log("Picked up");
      Destroy(other.gameObject, delay);
      hasPackage = true;
      spriteRenderer.color = hasPackageColor;
    }

   if (other.tag == "Customer" && hasPackage) {
      Debug.Log("Delivered!");
      hasPackage = false;
      spriteRenderer.color = noPackageColor;
    }
   }
}
