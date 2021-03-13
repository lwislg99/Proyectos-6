using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Items : MonoBehaviour
{
    
    
    public string name;
    public string description;
    public Sprite itemImage;

    public int level;
    public int type;

    public Item item;
    
     public Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
        player = FindObjectOfType<Player>();
        GetComponent<SpriteRenderer>().sprite = item.itemImage;
        

    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player = collision.gameObject.GetComponent<Player>();
            if (type == 1)
            {
                if (level == 1)
                {
                    player.dano = player.dano + 1;
                }else if (level == 2)
                {
                    player.dano = player.dano + 2;
                }else if (level == 3)
                {
                    player.dano = player.dano + 3;
                }else if (level == 4)
                {
                    player.dano = player.dano + 4;
                }
            }
            if (type == 2)
            {
                if (level == 1)
                {
                    player.Velocidad = player.Velocidad + 1;
                }else if (level == 2)
                {
                    player.Velocidad = player.Velocidad + 2;
                }else if (level == 3)
                {
                    player.Velocidad = player.Velocidad + 3;
                }else if (level == 4)
                {
                    player.Velocidad = player.Velocidad + 4;
                }
            }
            if (type == 3)
            {
                if (level == 1)
                {
                    player.vidaMax = player.vidaMax + 1;
                }else if (level == 2)
                {
                    player.vidaMax = player.vidaMax + 2;
                }else if (level == 3)
                {
                    player.vidaMax = player.vidaMax + 3;
                }else if (level == 4)
                {
                    player.vidaMax = player.vidaMax + 4;
                }
            }
            if (type == 4)
            {
                if (level == 1)
                {
                    player.vida = player.vida + 1;
                    if (player.vida > player.vidaMax)
                    {
                        player.vida = player.vidaMax;
                    }
                }else if (level == 2)
                {
                    player.vida = player.vida + 2;
                    if (player.vida > player.vidaMax)
                    {
                        player.vida = player.vidaMax;
                    }
                }else if (level == 3)
                {
                    player.vida = player.vida + 3;
                    if (player.vida > player.vidaMax)
                    {
                        player.vida = player.vidaMax;
                    }
                }else if (level == 4)
                {
                    player.vida = player.vida + 4;
                    if (player.vida > player.vidaMax)
                    {
                        player.vida = player.vidaMax;
                    }
                }
            }

            Destroy(gameObject);

        }

    }
    
}
