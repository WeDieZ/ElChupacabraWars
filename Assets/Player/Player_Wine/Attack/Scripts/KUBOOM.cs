using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KUBOOM : MonoBehaviour
{
    public float maxSize = 7.5f;
    public float speed = 5;
    void Start()
    {
        transform.localScale = Vector3.zero;        
    }
    void Update()
    {
        transform.localScale += Vector3.one * Time.deltaTime * speed;

        if (transform.localScale.x > maxSize)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        var Wine_HP = other.GetComponent<HP_Wine>();
        if (Wine_HP != null)
        {
            Wine_HP.DealDamageKuboom();
        }

        var Enemy_HP = other.GetComponent<EnemyHealth>();
        if (Enemy_HP != null)
        {
            Enemy_HP.hp_value -= 10;
        }
    }
}
