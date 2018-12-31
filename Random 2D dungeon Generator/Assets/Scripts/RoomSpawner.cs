using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{

    public int openingDirection;
    // 1 --> Need bottom door
    // 2 --> Need top door
    // 3 --> Need left door
    // 4 --> Need right door


    private RoomTemplates templates;
    private int rand;
    private bool spawned = false;

    void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        Invoke("Spawn", 0.1f);  // invoke() calss a function from the script with a time delay, to ensure that rooms aren't spawning every frame
    }

    void Spawn()
        {
            if (spawned == false  && templates.spawns.Length <= templates.limit) // so we know that our spawn point has not spawned a room already
            {
                if (openingDirection == 1)
                {
                    // spawn a room with a bottom door
                    rand = Random.Range(0, templates.bottomRooms.Length);
                    Instantiate(templates.bottomRooms[rand], transform.position, Quaternion.identity);
                }
                else if (openingDirection == 2)
                {
                    // spawn a room with a top door
                    rand = Random.Range(0, templates.topRooms.Length);
                    Instantiate(templates.topRooms[rand], transform.position, Quaternion.identity);
                }
                else if (openingDirection == 3)
                {
                    // spawn a room with a left door
                    rand = Random.Range(0, templates.leftRooms.Length);
                    Instantiate(templates.leftRooms[rand], transform.position, Quaternion.identity);
                }
                else if (openingDirection == 4)
                {
                    // spawn a room with a right door
                    rand = Random.Range(0, templates.rightRooms.Length);
                    Instantiate(templates.rightRooms[rand], transform.position, Quaternion.identity);
                }
                spawned = true; // no extra rooms will be spawned
            }
        }
        

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("SpawnPoint") && other.GetComponent<RoomSpawner>().spawned == true)
        {
            //Instantiate(templates.closedRoom, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        if (other.CompareTag("StartingPoint"))
        {
            Destroy(gameObject);
        }
    }
}