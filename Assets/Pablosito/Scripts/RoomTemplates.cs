using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplates : MonoBehaviour
{
    public GameObject[] bottomRooms;
    public GameObject[] topRooms;
    public GameObject[] leftRooms;
    public GameObject[] rightRooms;

    public GameObject[] bottomRoomsClosed;
    public GameObject[] topRoomsClosed;
    public GameObject[] leftRoomsClosed;
    public GameObject[] rightRoomsClosed;

    public GameObject closedRoom;

    public List<GameObject> rooms;

    public float waitTime;
    private bool spawnedBoss;
    public GameObject boss;
    public GameObject cofre;

    public GameObject[] items;

    private RoomTemplates templates;
    private bool cofre1;
    private bool cofre2;
    private bool cofre3;
    private bool cofre4;
    private bool cofre5;





    // Start is called before the first frame update
    void Start()
    {
        cofre1 = true;
        cofre2 = true;
        cofre3 = true;
        cofre4 = true;
        cofre5 = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(rooms.Count >3 && cofre1 == true)
        {

            for (int i = 0; i < rooms.Count; i++)
            {
                if (i == 3)
                {
                    Instantiate(cofre, rooms[i].transform.position, Quaternion.identity);
                    cofre1=false;
                }

            }
        }
        if (rooms.Count > 3 && cofre2 == true)
        {

            for (int i = 0; i < rooms.Count; i++)
            {
                if (i == 5)
                {
                    Instantiate(cofre, rooms[i].transform.position, Quaternion.identity);
                    cofre2 = false;
                }

            }
        }
        if (rooms.Count > 3 && cofre3 == true)
        {

            for (int i = 0; i < rooms.Count; i++)
            {
                if (i == 8)
                {
                    Instantiate(cofre, rooms[i].transform.position, Quaternion.identity);
                    cofre3 = false;
                }

            }
        }
        if (rooms.Count > 4 && cofre4 == true)
        {

            for (int i = 0; i < rooms.Count; i++)
            {
                if (i == 12)
                {
                    Instantiate(cofre, rooms[i].transform.position, Quaternion.identity);
                    cofre4 = false;
                }

            }
        }
        if (rooms.Count > 4 && cofre5 == true)
        {

            for (int i = 0; i < rooms.Count; i++)
            {
                if (i == 16)
                {
                    Instantiate(cofre, rooms[i].transform.position, Quaternion.identity);
                    cofre5 = false;
                }

            }
        }
        /*
        if(waitTime<= 0 && spawnedBoss ==false)
        {
            for(int i = 0; i<rooms.Count; i++)
            {
                if(i==rooms.Count-1)
                {
                    Instantiate(boss, rooms[i].transform.position, Quaternion.identity);
                    spawnedBoss = true;
                }

            }
        }else
        {
            waitTime -= Time.deltaTime;
        }
        */
    }
}
