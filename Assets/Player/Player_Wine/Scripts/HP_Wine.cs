using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HP_Wine : MonoBehaviour
{
    public float hp = 100;
    public RectTransform valueRectTransform;
    private float _maxValue;
    public GameObject OnGameUI;
    public GameObject OffGameUI;
    public GameObject HealEffect;

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

        if (hp <= 0)
        {
            OnDead();
        }

    }

    public void DealDamage()
    {
        hp -= 15 * Time.deltaTime;

        DrawHP();
    }

    public void DealDamageKuboom()
    {
        hp -= 25;

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
        GetComponent<WineCaster>().enabled = false;
    }

    public void DrawHP()
    {
        valueRectTransform.anchorMax = new Vector2(hp / _maxValue, 1);
    }
}