using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump1 : MonoBehaviour
{
    public float jumpPower;
    private Rigidbody2D rb;
    private bool isJumping = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.velocity = Vector3.up * jumpPower;
            isJumping = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Asufaruto"))
        {
            isJumping = false;
        }
    }
}
