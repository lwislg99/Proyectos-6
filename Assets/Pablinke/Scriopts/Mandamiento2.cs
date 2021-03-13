using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mandamiento2 : MonoBehaviour
{
    public Player PlayerI;
    // Start is called before the first frame update
    void Start()
    {
        /*PlayerI = GetComponent<Player>();*/
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
                
                PlayerI.Mandato2 = true;
                PlayerI.Mandato1 = false;
                PlayerI.interacionDisponible = false;
                Destroy(this.gameObject);
            }
        }
    }
}
