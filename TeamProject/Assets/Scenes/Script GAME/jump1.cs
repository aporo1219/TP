using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump1 : MonoBehaviour
{
    public float jumpPower;
    private Rigidbody2D rb;
    private bool isJumping = false;
    private float timer;
    private int i;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        timer = 0.0f;
        
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
        if(collision.gameObject.tag=="empty ca")
        {
            jumpPower = 6;
            Invoke(nameof(Timer), 4.0f);
        }
    }

    public void Timer()
    {
        jumpPower = 8;
        Debug.Log("ジャンプ力が戻る");
        
    }
}
