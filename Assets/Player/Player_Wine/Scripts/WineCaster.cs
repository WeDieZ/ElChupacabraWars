using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WineCaster : MonoBehaviour
{
    public Rigidbody WinePrefab;
    public Transform WineSource;
    public float force = 500;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var wine = Instantiate(WinePrefab);
            wine.transform.position = WineSource.position;
            wine.GetComponent<Rigidbody>().AddForce(WineSource.transform.forward * force);
        }
    }
}
