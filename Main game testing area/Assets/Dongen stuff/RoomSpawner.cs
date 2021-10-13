using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public int openingDirection;
    /*
    1 = bottom
    2 = top
    3 = left
    4 = right
    */

    private RoomTemplates templates;
    private int rand;
    private bool spawned = false;
    private GameObject parent;
    private void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        Invoke("Spawn", .1f);
        parent = GameObject.Find("Room templates");
    }

    private void Spawn()
    {
        if (spawned == false && parent.transform.childCount <=50)
        {
            if (openingDirection == 1)
            {
                //bottm door
                rand = Random.Range(0, templates.bottomRooms.Length);
                var a = Instantiate(templates.bottomRooms[rand], transform.position, templates.bottomRooms[rand].transform.rotation);
                a.transform.parent = parent.transform;
            }
            else if (openingDirection == 2)
            {
                //top
                rand = Random.Range(0, templates.topRooms.Length);
                var a = Instantiate(templates.topRooms[rand], transform.position, templates.topRooms[rand].transform.rotation);
                a.transform.parent = parent.transform;
            }
            else if (openingDirection == 3)
            {
                //left
                rand = Random.Range(0, templates.leftRooms.Length);
                var a = Instantiate(templates.leftRooms[rand], transform.position, templates.leftRooms[rand].transform.rotation);
                a.transform.parent = parent.transform;
            }
            else if (openingDirection == 4)
            {
                //right
                rand = Random.Range(0, templates.rightRooms.Length);
                var a = Instantiate(templates.rightRooms[rand], transform.position, templates.rightRooms[rand].transform.rotation);
                a.transform.parent = parent.transform;
            }
            spawned = true;
        }else if(spawned == false)
        {
            if (openingDirection == 1)
            {
                //bottm door
                rand = Random.Range(0, templates.bottomRoomsend.Length);
                var a = Instantiate(templates.bottomRoomsend[rand], transform.position, templates.bottomRoomsend[rand].transform.rotation);
                a.transform.parent = parent.transform;
            }
            else if (openingDirection == 2)
            {
                //top
                rand = Random.Range(0, templates.topRoomsend.Length);
                var a = Instantiate(templates.topRoomsend[rand], transform.position, templates.topRoomsend[rand].transform.rotation);
                a.transform.parent = parent.transform;
            }
            else if (openingDirection == 3)
            {
                //left
                rand = Random.Range(0, templates.leftRoomsend.Length);
                var a = Instantiate(templates.leftRoomsend[rand], transform.position, templates.leftRoomsend[rand].transform.rotation);
                a.transform.parent = parent.transform;
            }
            else if (openingDirection == 4)
            {
                //right
                rand = Random.Range(0, templates.rightRoomsend.Length);
                var a = Instantiate(templates.rightRoomsend[rand], transform.position, templates.rightRoomsend[rand].transform.rotation);
                a.transform.parent = parent.transform;
            }
        }

    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("hit");
        if(other.CompareTag("Spawn"))
        {
            if(other.GetComponent<RoomSpawner>().spawned == false && spawned == false)
            {
                //spawn wall
                var a = Instantiate(templates.closedRoom, transform.position, templates.closedRoom.transform.rotation);
                a.transform.parent = parent.transform;
                Destroy(gameObject);
            }
        }
        spawned = true;
    }
}
