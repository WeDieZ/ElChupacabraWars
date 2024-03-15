using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Main_Menu : MonoBehaviour
{
    public GameObject Desciption;
    public void StartButton()
    {
        SceneManager.LoadScene("ChoosePlayer");
    }

    public void DescriptionButton()
    {
        Desciption.SetActive(true);
    }

    public void DescriptionButtonBack()
    {
        Desciption.SetActive(false);
    }

}
