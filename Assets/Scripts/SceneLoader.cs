using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{

    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }


    public void LoadLevelSelect()
    {
        SceneManager.LoadScene("Level1Select");
    }

    public void LoadNewGame()
    {
        SceneManager.LoadScene("Level1");
    }
}
