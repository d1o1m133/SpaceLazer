using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f;
    public Transform goal;
    
    void Start()
    {
        
    }

    
    void LateUpdate()
    {
        Vector2 direction = goal.position - this.transform.position;
        this.transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
}
