using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float hp_value = 30;
    void Start()
    {
        
    }
    void Update()
    {
        if (hp_value <=0)
        {
            Destroy(gameObject);
        }
    }
}
