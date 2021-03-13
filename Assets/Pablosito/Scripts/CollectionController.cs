using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Item
{
    public string mame;
    public string description;
    public Sprite itemImage;
}

public class CollectionController : MonoBehaviour
{
    public Item item;
    public float healPlayer;
    public float healthChange;
    public float moveSpeedChange;
    public float attackSpeedChange;
    public float dmgChange;
   
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = item.itemImage;
        Destroy(GetComponent <PolygonCollider2D>());
        gameObject.AddComponent<PolygonCollider2D>();
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
         if(collision.tag =="player")
        {

            //PlayerController.collectedAmount++;
            //GameControler.HealPlayer(healPlayer);
            //GameControler.HealthChange(healthChange);
            //GameControler.MoveSpeedChange(moveSpeedChange);
            //GameControler.AttackSpeedChange(attackSpeedChange);
            //GameControler.DmgChange(dmgChange);
            Destroy(gameObject);
        }
    }
}
