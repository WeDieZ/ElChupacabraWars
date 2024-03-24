using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bread : MonoBehaviour
{
    public GameObject _Steak;
    public GameObject Enemy_Bread;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _Steak.SetActive(true);
            Destroy(gameObject);
            Enemy_Bread.SetActive(true);
        }
    }
}
