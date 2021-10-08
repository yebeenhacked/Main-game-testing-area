using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword_enemy : MonoBehaviour
{
    public GameObject myPrefab;

    private void OnDestroy()
    {
        Vector3 a = transform.position;
        var randomPosition = new Vector3(Random.Range(a.x-.5f, a.x +.5f), Random.Range(a.y - .5f, a.y + .5f), Random.Range(a.z - .5f, a.z + .5f));
        Instantiate(myPrefab, randomPosition , Quaternion.identity);

        randomPosition = new Vector3(Random.Range(a.x - .5f, a.x + .5f), Random.Range(a.y - .5f, a.y + .5f), Random.Range(a.z - .5f, a.z + .5f));
        Instantiate(myPrefab, randomPosition, Quaternion.identity);

        randomPosition = new Vector3(Random.Range(a.x - .5f, a.x + .5f), Random.Range(a.y - .5f, a.y + .5f), Random.Range(a.z - .5f, a.z + .5f));
        Instantiate(myPrefab, randomPosition, Quaternion.identity);

        randomPosition = new Vector3(Random.Range(a.x - .5f, a.x + .5f), Random.Range(a.y - .5f, a.y + .5f), Random.Range(a.z - .5f, a.z + .5f));
        Instantiate(myPrefab, randomPosition, Quaternion.identity);

        randomPosition = new Vector3(Random.Range(a.x - .5f, a.x + .5f), Random.Range(a.y - .5f, a.y + .5f), Random.Range(a.z - .5f, a.z + .5f));
        Instantiate(myPrefab, randomPosition, Quaternion.identity);
    }
}
