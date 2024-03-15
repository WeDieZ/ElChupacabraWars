using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurgerCaster : MonoBehaviour
{
    public Burger_Attack Burger_attack;
    public Transform BurgerSource;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(Burger_attack, BurgerSource.position, BurgerSource.rotation);
        }
    }
}
