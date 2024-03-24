using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public float hp_value = 150;
    public GameObject Win;
    void Update()
    {
        if (hp_value <=0)
        {
            Destroy(gameObject);
            Win.SetActive(true);
        }
    }
}
