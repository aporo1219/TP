using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shift : MonoBehaviour
{
    //•à‚­
    private float STEP = 0.0f;
    //‚µ‚á‚ª‚Þ
    private Animator anim = null;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
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
