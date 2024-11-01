using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        
    }


    #region Menu Handler
    //Orden: Menu(0), Jugar(1), GameOver(2).
    public void Jugar()
    {
        SceneManager.LoadScene(1);
    }

    public void Salir()
    {
        Console.WriteLine("Adios!");
        Application.Quit();
    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene(0);
    }

    public void GameOver()
    {
        SceneManager.LoadScene(2);
    }
    #endregion


    
}
