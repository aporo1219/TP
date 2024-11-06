using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float TimerS = 0.0f;
    private Transform _initialTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimerS += Time.deltaTime;
        if (TimerS != 30.0)
        {
            
            _initialTransform = gameObject.transform;
            transform.position += new Vector3(-3, 0) * Time.deltaTime;
                
            
           //gameObject.transform.position = _initialTransform.position;
        }

    }
}
