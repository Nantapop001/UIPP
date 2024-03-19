using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void Button_MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
