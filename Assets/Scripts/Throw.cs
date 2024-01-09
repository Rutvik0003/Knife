using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Throw : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Speed;
    public GameObject Wood;
    public bool onwood;
    
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (onwood == false)
        {
            rb.MovePosition (rb.position + Vector2.up*Speed*Time.deltaTime);
           
            
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wood")
        {
            onwood = true;
            transform.SetParent(Wood.transform);
            onwood = false;
        }

        if (collision.gameObject.tag =="Knife")
        {
            SceneManager.LoadScene(2);
        }
    }




}
