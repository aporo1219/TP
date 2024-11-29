using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //•à‚­
     private float STEP = 3.0f;
    //‚µ‚á‚ª‚Þ
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
        //‰EŒü‚«
         this.transform.position += new Vector3(STEP * Time.deltaTime, 0, 0);
    }
}
