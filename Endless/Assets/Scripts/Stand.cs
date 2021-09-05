using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stand : MonoBehaviour
{
    float hiz = 5;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(0, 0, -1 *hiz * Time.deltaTime);
    }
}
