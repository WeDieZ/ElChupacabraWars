using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato : MonoBehaviour
{
    public GameObject _Cheese;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _Cheese.SetActive(true);
            Destroy(gameObject);
        }
    }
}
