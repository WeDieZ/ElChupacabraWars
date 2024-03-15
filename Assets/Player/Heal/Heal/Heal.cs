using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    public float healAmount = 50;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        var BurgerHealth = other.gameObject.GetComponent<HP_Burger>();

        if (BurgerHealth != null)
        {
            BurgerHealth.AddHealth(healAmount);
            Destroy(gameObject);
        }

        var WineHealth = other.gameObject.GetComponent<HP_Wine>();

        if (WineHealth != null)
        {
            WineHealth.AddHealth(healAmount);
            Destroy(gameObject);
        }

    }
}
