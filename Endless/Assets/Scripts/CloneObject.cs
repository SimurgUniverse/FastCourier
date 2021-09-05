using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneObject : MonoBehaviour
{
    // create stand postbox and dollar clone
    public GameObject dolar;
    public GameObject postbox;
    public GameObject stand;

    public Transform player;
   

    float deleteTime = 5f;

    float rightCoordinate = 2f;
    float leftCoordinate = 2.5f;
    void Start()
    {
        InvokeRepeating("objectClone", 0, 0.5f);
    }

    // create random object

    void objectClone()
    {
        int randomNumber = Random.Range(0, 100);

        if (randomNumber > 0 && randomNumber < 70)
        {
            Clone(dolar, 0.5f);
        }
        if (randomNumber > 70 && randomNumber < 85)
        {
            Clone(postbox, 0f);
        }
        if (randomNumber > 85 && randomNumber < 100)
        {
            Clone(stand, 0f);
        }
    }


    void Clone(GameObject object1, float yCoordinate)
    {
        GameObject newObject = Instantiate(object1);
        newObject.transform.position = new Vector3(Random.Range(-1 * leftCoordinate, rightCoordinate), yCoordinate, player.position.z+20f); 
    
        Destroy(newObject, deleteTime);
    }
    void Update()
    {
       
    }
}
