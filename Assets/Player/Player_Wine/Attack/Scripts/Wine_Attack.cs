using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wine_Attack : MonoBehaviour
{
    public float delay = 3;
    public GameObject ExplosionPrefab;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Invoke("Explosion", delay);
    }

    private void Explosion()
    {
        Destroy(gameObject);
        var explosion = Instantiate(ExplosionPrefab);
        explosion.transform.position = transform.position;
    }
}
