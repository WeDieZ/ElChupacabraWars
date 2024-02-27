using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public float Speed = 5;
    public float FlyTime = 5;
    public float damage = 1;

    void Start()
    {
        Invoke("DestroyFireball", FlyTime);
    }

    void FixedUpdate()
    {
        FixedUpdateMoveFireball();
    }

    private void OnCollisionEnter(Collision collision)
    {
        DestroyFireball();

        DamageEnemy(collision);
    }

    // zzz //

    private void FixedUpdateMoveFireball()
    {
        transform.position += transform.forward * Time.fixedDeltaTime * Speed;
    }

    private void DestroyFireball()
    {
        Destroy(gameObject);
    }

    private void DamageEnemy(Collision collision)
    {
        var enemy_health = collision.gameObject.GetComponent<EnemyHealth>();

        if (enemy_health != null)
        {
            enemy_health.hp_value -= damage;
        }
    }
}
