using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorBala : MonoBehaviour
{

    public float lifeTime;

    public Player PlayerI;


    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(DeathDelay());

        PlayerI=FindObjectOfType<Player>();

    }

    // Update is called once per frame
    void Update()
    {
        PlayerI.visualBala.SetActive(true);
        PlayerI.visualBala.transform.position = this.transform.position;
    }
    IEnumerator DeathDelay()
    {
        yield return new WaitForSeconds(lifeTime);
        PlayerI.visualBala.SetActive(false);
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Spawnpoint")
        {

        }
        else
        {
            Destroy(gameObject);
        }
    }
}
