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
    public GameObject laserPrefab;
    private float projectileSpeed = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    
    void Update()
    {
        Fire();
        Move();
    }

    private void Fire()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            
                GameObject laser = Instantiate(laserPrefab, transform.position, Quaternion.identity) as GameObject;
                laser.GetComponent<Rigidbody2D>().velocity = new Vector2(0, projectileSpeed);
        }
    }

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

