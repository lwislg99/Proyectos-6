using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    private RoomTemplates templates;
    private int rand;
    // Start is called before the first frame update
    void Start()
    {
        templates = GameObject.FindWithTag("Rooms").GetComponent<RoomTemplates>();
        Invoke("Spawn", 0.1f);

    }
    void Spawn()
    {
        rand = Random.Range(0, templates.items.Length);
        Instantiate(templates.items[rand], transform.position, templates.items[rand].transform.rotation);
    }
    void spawn()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
