using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplates : MonoBehaviour {

    public GameObject[] bottomRooms;
    public GameObject[] topRooms;
    public GameObject[] leftRooms;
    public GameObject[] rightRooms;

    private GameObject[] bottomRoomsNew;
    private GameObject[] topRoomsNew;
    private GameObject[] leftRoomsNew;
    private GameObject[] rightRoomsNew;

    public GameObject closedRoom;
    public int limit;
    public GameObject[] spawns;


    private void Start()
    {
    }

    private void Update()
    {
        spawns = GameObject.FindGameObjectsWithTag("SpawnPoint");
        //if(spawns.Length >= limit)
        //{
        //    bottomRooms = bottomRoomsNew;
        //    topRooms = topRoomsNew;
        //    leftRooms = leftRoomsNew;
         //   rightRooms = rightRoomsNew;
       // }
    }
}