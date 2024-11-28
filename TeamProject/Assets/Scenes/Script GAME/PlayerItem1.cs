using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        
        if(other.gameObject.tag == "Pud night")
        {
            calobar.value += 15;
        }

        if(other.gameObject.tag == "Cook night")
        {
            calobar.value += 5;
        }

        if(other.gameObject.tag == "Choco night")
        {
            calobar.value += 10;
        }
    } 
    public void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.tag == "pitfall")
       {
                calobar.value -= 20;

       }
    }

}




