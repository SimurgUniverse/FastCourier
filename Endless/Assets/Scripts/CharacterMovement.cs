using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    
    bool right = true;

    public Animator animation1;

    public int point = 0; //public because we will access from koli script
    int a = 0;
    int lev = 1;
    

    public GameObject EndPanel;

    public GameObject dolareffect;

    public GameObject koli;

    public Transform way;
    public Transform way1;

    public Rigidbody rigid;

   

    public TMPro.TextMeshProUGUI score;
    public TMPro.TextMeshProUGUI level; 


    private void OnTriggerEnter(Collider other)
    {
        // endless code
        if (other.gameObject.name == "end")
        {
            way1.position = new Vector3(way.position.x, way.position.y, way.position.z + 30.0f);
            a++;

            if (a % 2 == 0)
            {
                lev ++ ;
                level.text = lev.ToString();
            }

        }
        if (other.gameObject.name == "end_1")
        {
            way.position = new Vector3(way1.position.x, way1.position.y, way1.position.z + 30.0f);
        }
       

        // failed
        if (other.gameObject.tag == "obstacle")
        {
            EndPanel.SetActive(true);
            Time.timeScale = 0.0f;
        }

        if (other.gameObject.tag == "postbox")
        {
           
            EndPanel.SetActive(true);
            Time.timeScale = 0.0f;
        }

        // dollar-point
        if (other.gameObject.tag == "money")
        {
            GameObject dolars = Instantiate(dolareffect, other.gameObject.transform.position, Quaternion.identity);
            Destroy(dolars, 0.5f);
            
            Destroy(other.gameObject);
            
            point++;
         //   score.text = point.ToString("0000");
           
        }

    }

    private void Update()
    {
        movement();
        score.text = point.ToString("0000");
    }



    private void movement()
    {
        // jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animation1.SetTrigger("jump");
            rigid.velocity = Vector3.up * 300.0f * Time.deltaTime;    
        
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            animation1.SetTrigger("a");
          
        }

        // player's right-left movement
        if (Input.GetKeyDown(KeyCode.D))
        {
            right = true;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            right = false;
        }

        if (right)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(3.0f, transform.position.y, transform.position.z), Time.deltaTime * 0.5f);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(-3.0f, transform.position.y, transform.position.z), Time.deltaTime * 0.5f);
        }

        transform.Translate(0, 0, 3.5f * Time.deltaTime); 


    }

    // parcel shot
    void Firlat()
    {

        Instantiate(koli, this.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
        
    }

    void finish_jump()
        {
            animation1.SetTrigger("jump");
        }
   


    

}
