using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class WoodMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float RotationSpeed;
    
    

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        transform.Rotate(0, 0, RotationSpeed * Time.deltaTime);
    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Knife")
        {
            rb.angularVelocity = rb.angularVelocity;
           
            
        }

    }

    
}