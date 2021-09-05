using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Koli : MonoBehaviour
{
    CharacterMovement character;
  
    void Start()
    {
         character = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMovement>();
        Destroy(gameObject, 5f); //delete parcel
    }

 
    void Update()
    {
        //parcel movement
        transform.Translate(Vector3.forward * 5 * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("postbox"))
        {
            character.point += 10;
            GameObject dollar=  Instantiate(character.dolareffect, other.transform.position, Quaternion.identity);
            Destroy(dollar, .5f);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
