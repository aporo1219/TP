using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMove : MonoBehaviour
{
    public float TimerS = 0.0f ;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        TimerS += Time.deltaTime;
        if(TimerS != 30.0)
        {
          transform.position += new Vector3(-3, 0) * Time.deltaTime;
        }
        
    }
}
