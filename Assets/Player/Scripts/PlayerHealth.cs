using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float hp = 100;
    public RectTransform valueRectTransform;
    private float _maxValue;
    public GameObject OnGameUI;
    public GameObject OffGameUI;

    void Start()
    {
        _maxValue = hp;
        DrawHP();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && hp<=0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void DealDamage()
    {
        hp -= 1;
        if (hp <= 0)
        {
            OnDead();
        }

        DrawHP();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Respawn")
        {
            OnDead();
        }
    }


    //zzz//

    public void OnDead()
    {
        OnGameUI.SetActive(false);
        OffGameUI.SetActive(true);
        GetComponent<PlayerController>().enabled = false;
        GetComponent<FireBallCaster>().enabled = false;

    }

    public void DrawHP()
    {
        valueRectTransform.anchorMax = new Vector2(hp / _maxValue, 1);
    }
}
