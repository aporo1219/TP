using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollter : MonoBehaviour
{

    private float STEP = 5.0f;


    void Update()
    {
        //‰EŒü‚«
        this.transform.position += new Vector3(STEP * Time.deltaTime, 0, 0);
    }
}
