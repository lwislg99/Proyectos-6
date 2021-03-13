using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cofre : MonoBehaviour
{
    public GameObject itemSpawner;
    public GameObject cofreAbierto;
    
           public Player PlayerI;


            // Start is called before the first frame update
            void Start()
            {

            }

            // Update is called once per frame
            void Update()
            {

            }
            private void OnTriggerEnter2D(Collider2D collision)
            {
                if (collision.tag == "NoCofre")
                {
                    Destroy(gameObject);

                }
            }
            void OnTriggerStay2D(Collider2D collision)
            {

                
                
                if (collision.CompareTag("Player"))
                {

                    PlayerI = collision.gameObject.GetComponent<Player>();
                    if (Input.GetButtonDown("Habilidad") && PlayerI.interacionDisponible == true)
                    {
                
                        Instantiate(itemSpawner, transform.position, itemSpawner.transform.rotation);
                        Instantiate(cofreAbierto, transform.position, cofreAbierto.transform.rotation);
                        PlayerI.interacionDisponible = false;
                        Destroy(this.gameObject);
                    }
            
                }
            }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerI.interacionDisponible = false;
        }
    }


}
