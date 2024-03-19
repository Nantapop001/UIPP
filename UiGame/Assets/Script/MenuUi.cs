using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUi : MonoBehaviour
{
    public void Button_Start()
    {
        SceneManager.LoadScene("Mode");
    }
    
    public void Button_Credit()
    {
        SceneManager.LoadScene("Credit");
    }

    public void Button_Quit()
    {
#if UNIY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
