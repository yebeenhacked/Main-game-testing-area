using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name != "Spawn room" && other.name != "Player") { 
        Destroy(other.gameObject);
    }
    }
}
