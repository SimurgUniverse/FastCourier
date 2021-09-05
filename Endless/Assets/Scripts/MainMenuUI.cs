using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public GameObject settings;
  
     //sound
    private AudioSource sound;
    public Slider slider;
    
     void Start()
    {
        sound = GameObject.FindGameObjectWithTag("muzik").GetComponent<AudioManager>().GetComponent<AudioSource>();
        
        slider.value = PlayerPrefs.GetFloat("PrefsSound");

    }
    private void Update()
    {
        sound.volume = slider.value;
        
    }



    //buttons
    public void GameStart()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void Settings()
    {
        settings.SetActive(true);
    }
    public void Back()
    {
            settings.SetActive(false);
        PlayerPrefs.SetFloat("PrefsSound", slider.value);
    }
    public void GameQuit()
    {
        Application.Quit();
    }
}
