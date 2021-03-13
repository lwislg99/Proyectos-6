using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public int openingDirection;

    //1 - bottom door
    //2 - top door
    //3 - right door
    //4 - left door

    private RoomTemplates templates;
    private int rand;
    public bool spawned = false;
    public bool colision = true;
    
    

    void Start()
    {
        templates = GameObject.FindWithTag("Rooms").GetComponent<RoomTemplates>();
        Invoke("Spawn",0.1f);
       
        
        
    }
    private void Update()
    {
        
    }

    // Update is called once per frame
    void Spawn()
    {
        if(spawned == false && templates.rooms.Count >= 20)
        {
            
            if (openingDirection == 1)
            {
                rand = Random.Range(0, templates.bottomRoomsClosed.Length);
                Instantiate(templates.bottomRoomsClosed[rand], transform.position, templates.bottomRoomsClosed[rand].transform.rotation);
            }
            else if (openingDirection == 2)
            {
                rand = Random.Range(0, templates.topRoomsClosed.Length);
                Instantiate(templates.topRoomsClosed[rand], transform.position, templates.topRoomsClosed[rand].transform.rotation);
            }
            else if (openingDirection == 3)
            {
                rand = Random.Range(0, templates.leftRoomsClosed.Length);
                Instantiate(templates.leftRoomsClosed[rand], transform.position, templates.leftRoomsClosed[rand].transform.rotation);
            }
            else if (openingDirection == 4)
            {
                rand = Random.Range(0, templates.rightRoomsClosed.Length);
                Instantiate(templates.rightRoomsClosed[rand], transform.position, templates.rightRoomsClosed[rand].transform.rotation);

            }
            spawned = true;
        }
        if(spawned == false)
        {
            
            if (openingDirection == 1)
            {
                rand = Random.Range(0, templates.bottomRooms.Length);
                Instantiate(templates.bottomRooms[rand], transform.position, templates.bottomRooms[rand].transform.rotation);
            }
            else if (openingDirection == 2)
            {
                rand = Random.Range(0, templates.topRooms.Length);
                Instantiate(templates.topRooms[rand], transform.position, templates.topRooms[rand].transform.rotation);
            }
            else if (openingDirection == 3)
            {
                rand = Random.Range(0, templates.leftRooms.Length);
                Instantiate(templates.leftRooms[rand], transform.position, templates.leftRooms[rand].transform.rotation);
            }
            else if (openingDirection == 4)
            {
                rand = Random.Range(0, templates.rightRooms.Length);
                Instantiate(templates.rightRooms[rand], transform.position, templates.rightRooms[rand].transform.rotation);
                
            }
            spawned = true;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("ClosedRoom"))
        {
            spawned = true;
        }
        if(other.CompareTag("SpawnPoint"))
        {
            if (templates.rooms.Count < 5)
            {
                spawned = true;
            }

            if (other.GetComponent<RoomSpawner>().spawned== false && spawned==false)
            {
                Instantiate(templates.closedRoom, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
            spawned = true;
            if (other.GetComponent<RoomSpawner>().spawned == false)
            {
                Destroy(gameObject);
            }
            


        }
    }
    
}
