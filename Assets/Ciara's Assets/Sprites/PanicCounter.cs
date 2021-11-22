using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanicCounter : MonoBehaviour
{
    public int currentPanic = 0;

    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Bullet(Clone)")
        {
            currentPanic += 10;
            
            Destroy(collision.gameObject);

            print("I hit something and my health is " + currentPanic);

            if (currentPanic <= 100)
            {
                Destroy(gameObject);
            }

        }
    }

   }
