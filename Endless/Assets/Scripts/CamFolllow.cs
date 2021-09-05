using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFolllow : MonoBehaviour
{
    // camera follows the invisible cube above the character
    public Transform followcube;
    float distance; // for fixed distance

    private void Start()
    {
        distance = followcube.position.z - transform.position.z;
    }
    void Update()
    {
        
        transform.position = new Vector3(0, transform.position.y, followcube.position.z - distance);
    }

}
