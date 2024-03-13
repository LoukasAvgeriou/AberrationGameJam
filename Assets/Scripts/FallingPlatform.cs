using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    private bool timeToFall = false;
    private Rigidbody2D rb;
    public float speed = 5f; // Adjust this value to control the speed of downward movement

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.transform.SetParent(transform);
            timeToFall = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.SetParent(null);
    }


    private void FixedUpdate()
    {
        if (timeToFall)
        {
            // Move the object downwards
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

    void Update()
    {

        
        
    }
}
