using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float velocity = 4;
    private Rigidbody2D rb;
    public float speed = 3;

    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate () {

        // moveing right
        rb.velocity = Vector2.right * speed;

        if (Input.GetKeyDown("space"))
        {
            //jumping
            rb.velocity = Vector2.up * velocity;
        }
    }


}