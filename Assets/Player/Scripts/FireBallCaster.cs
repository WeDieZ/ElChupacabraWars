using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallCaster : MonoBehaviour
{
    public FireBall fireBall_prefab;
    public Transform FireballSource;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireBall_prefab, FireballSource.position, FireballSource.rotation);
        }
    }
}
