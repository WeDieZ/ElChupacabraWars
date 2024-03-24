﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HP_Burger : MonoBehaviour
{
    public float hp = 100;
    public RectTransform valueRectTransform;
    private float _maxValue;
    public GameObject OnGameUI;
    public GameObject OffGameUI;
    public GameObject HealEffect;
    public GameObject Win;
    void Start()
    {
        _maxValue = hp;
        DrawHP();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && hp <= 0)
        {
            SceneManager.LoadScene("MainMenu");
        }

        if (Input.GetKeyDown(KeyCode.R) && Win.active == true)
        {
            SceneManager.LoadScene("MainMenu");
        }

        if (hp <= 0)
        {
            OnDead();
        }

        if (Win.active == true)
        {
            OnGameUI.SetActive(false);
            GetComponent<PlayerController>().enabled = false;
            GetComponent<BurgerCaster>().enabled = false;
        }

    }

    public void DealDamage()
    {
        hp -= 15 * Time.deltaTime;

        DrawHP();
    }

    public void DealDamageBoss()
    {
        hp -= 25 * Time.deltaTime;

        DrawHP();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Respawn")
        {
            SceneManager.LoadScene("MainMenu");
        }
    }


    //zzz//

    public void AddHealth(float amount)
    {
        hp += amount;
        hp = Mathf.Clamp(hp, 0, _maxValue);
        DrawHP();
        HealEffect.GetComponent<ParticleSystem>().Play();
    }

    public void OnDead()
    {
        OnGameUI.SetActive(false);
        OffGameUI.SetActive(true);
        GetComponent<PlayerController>().enabled = false;
        GetComponent<BurgerCaster>().enabled = false;
    }

    public void DrawHP()
    {
        valueRectTransform.anchorMax = new Vector2(hp / _maxValue, 1);
    }
}