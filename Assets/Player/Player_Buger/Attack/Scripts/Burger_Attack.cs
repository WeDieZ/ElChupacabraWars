using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burger_Attack : MonoBehaviour
{
    public float Speed = 10;
    public float FlyTime = 5;
    public float damage = 1;

    void Start()
    {
        Invoke("DestroyBurger", FlyTime);
    }

    void FixedUpdate()
    {
        FixedUpdateMoveBurger();
    }

    private void OnCollisionEnter(Collision collision)
    {
        DestroyBurger();

        DamageEnemy(collision);
    }

    // zzz //

    private void FixedUpdateMoveBurger()
    {
        transform.position += transform.forward * Time.fixedDeltaTime * Speed;
    }

    private void DestroyBurger()
    {
        Destroy(gameObject);
    }

    private void DamageEnemy(Collision collision)
    {
        var enemy_health = collision.gameObject.GetComponent<EnemyHealth>();
        var boss_health = collision.gameObject.GetComponent<BossHealth>();

        if (enemy_health != null)
        {
            enemy_health.hp_value -= damage;
        }

        if (boss_health != null)
        {
            boss_health.hp_value -= damage;
        }    
    }
}
