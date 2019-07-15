using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {


    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadHallway()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadRoom1()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadRoom2()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadRoom3()
    {
        SceneManager.LoadScene(4);
    }

    public void LoadRoom4()
    {
        SceneManager.LoadScene(5);
    }

 
    public void LoadComputer()
    {
        SceneManager.LoadScene(6);
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene(7);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
