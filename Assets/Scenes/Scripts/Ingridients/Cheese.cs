using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheese : MonoBehaviour
{
    public GameObject Boss;
    public GameObject Barrier;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            Boss.SetActive(true);
            Barrier.SetActive(false);
        }
    }
}
