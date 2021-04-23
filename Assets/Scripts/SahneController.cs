using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneController : MonoBehaviour
{
    public void OyunaBasla(int id)
    {
        SceneManager.LoadScene(1);
        
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void SonSahne(int id)
    {
        SceneManager.LoadScene(2);

    }
}
