using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = UnityEngine.Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = UnityEngine.Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
        
    }

    void OnCollisionEnter2D(Collision2D other)  {
        moveSpeed = slowSpeed;
   }
   void OnTriggerEnter2D(Collider2D other) {
    if(other.tag == "SpeedUp") {
        moveSpeed = boostSpeed;
    }
   }
}
