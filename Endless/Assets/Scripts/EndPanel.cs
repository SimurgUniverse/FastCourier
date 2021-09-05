using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPanel : MonoBehaviour
{
    // if restart is clicked
    public void Restart()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(1);
    }

    // if menu is clicked
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
