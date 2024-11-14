using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollter : MonoBehaviour
{
    //歩く
    private float STEP = 3.0f;
    //しゃがむ
    private Animator anim = null;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontalKey = Input.GetAxis("Horizontal");

        if (horizontalKey < 0)
        {
            anim.SetBool("crouch", true);
        }
        else
        {
            anim.SetBool("crouch", false);
        }
        //右向き
        this.transform.position += new Vector3(STEP * Time.deltaTime, 0, 0);
    }
}
