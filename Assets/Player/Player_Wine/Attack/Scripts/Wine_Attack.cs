using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wine_Attack : MonoBehaviour
{
    public AudioSource bottle;
    public float delay = 3;
    public GameObject ExplosionPrefab;
    private void OnCollisionEnter(Collision collision)
    {
        Invoke("Explosion", delay);
        bottle.Play();
    }

    private void Explosion()
    {
        Destroy(gameObject);
        var explosion = Instantiate(ExplosionPrefab);
        explosion.transform.position = transform.position;
    }
}
