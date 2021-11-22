using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    private GameObject BulletClone;
    private float spawnDelayMin = 3f;
    private float spawnDelay = 1f;
    public Transform Player;


    [Header("Spawn Settings")]
    [SerializeField] private GameObject Bullet;

    [SerializeField] float spawnDelayMax = 3f;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    void Update()
    {
        
    }

    void Spawn()
    {
        Quaternion rotation = Quaternion.LookRotation(Player.transform.position);

        BulletClone = Instantiate(Bullet, transform.position, transform.rotation);

        spawnDelay = Random.Range(spawnDelayMin, spawnDelayMax);
        Invoke("Spawn", spawnDelay);
    }

    
}
