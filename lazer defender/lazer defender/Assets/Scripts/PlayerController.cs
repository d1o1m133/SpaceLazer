using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float mouseMoveSpeed = 1000f;
    private Vector3 mousePosition;
    private Vector2 direction;
    private Rigidbody2D rb;

    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    
    void Update()
    {Move();}
    
    private void Move()
    {
        if (Input.GetMouseButton(0))
        {
            
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            direction = (mousePosition - transform.position).normalized;
            float newX = direction.x * mouseMoveSpeed * Time.deltaTime;
            float newY = direction.y * mouseMoveSpeed * Time.deltaTime;
            
            rb.velocity = new Vector2(newX, newY);
           
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}

