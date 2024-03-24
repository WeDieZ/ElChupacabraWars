using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steak : MonoBehaviour
{
    public GameObject _Tomato;
    public GameObject Enemy_Steak;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _Tomato.SetActive(true);
            Destroy(gameObject);
            Enemy_Steak.SetActive(true);
        }
    }
}
