using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miguel : MonoBehaviour
{


    public Player PlayerI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            PlayerI = collision.gameObject.GetComponent<Player>();

            if (Input.GetButtonDown("Habilidad") && PlayerI.interacionDisponible == true)
            {
                
                PlayerI.ArcangelMiguel = true;
                PlayerI.ArcangelGabriel = false;
                PlayerI.interacionDisponible = false;

            }
        }
    }
}
