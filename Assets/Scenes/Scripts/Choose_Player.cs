using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Choose_Player : MonoBehaviour
{
    public void BurgerPlayer()
    {
        SceneManager.LoadScene("Level_Burger");
    }

    public void WinePlayer()
    {
        SceneManager.LoadScene("Level_Wine");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
