using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletController : MonoBehaviour
{
    private GameObject BulletClone;
   

    [SerializeField] private GameObject Player;
    [SerializeField] private float speed = 5f;


    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        Destroy(gameObject, 1.6f);
    }

    private void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.name == "Player")
        {
            Destroy(collider.gameObject);
            print("I hit something!");

            SceneManager.LoadScene("Level One");
            
        }

      /*if (collider.gameObject.name == "Bullet(Clone)")
        {
            Destroy(collider.gameObject);
            print("I hit something!");
            Destroy(gameObject);
        }*/
    }

}