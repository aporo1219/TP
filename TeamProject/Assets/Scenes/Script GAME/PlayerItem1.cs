using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerItem1 : MonoBehaviour
{
    public Slider calobar;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "chili pepper")
        {
            calobar.value -= 10;
            
        }

        if (other.gameObject.tag == "chocolate")
        {
            calobar.value += 20;
          
        }

        if (other.gameObject.tag == "cookie")
        {
            calobar.value += 10;
           
        }

        if (other.gameObject.tag == "dumbbell")
        {
            calobar.value -= 30;
            
        }

        if (other.gameObject.tag == "pudding")
        {
            calobar.value += 30;
          
        }

        if (other.gameObject.tag == "pitfall")
        {
            calobar.value -= 20;
           
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name.Contains("pitfall"))
        {
            calobar.value -= 20;
        }
    }
}