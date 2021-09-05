using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //music
    public AudioSource audio1;
    private void Awake()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("muzik");
        if (obj.Length <= 1)
        {
            DontDestroyOnLoad(this.gameObject);
        }
        else
            Destroy(gameObject);

    }
    void Start()
    {
   
    }
 

}
