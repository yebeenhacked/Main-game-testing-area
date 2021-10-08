using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject myPrefab;
    private float time = 7f;
    // Update is called once per frame
    void Update()
    {
        time += 1f * Time.deltaTime;

        if (time >= 7)
        {
            time = 0;
            Vector3 a = transform.position;
            var randomPosition = new Vector3(Random.Range(a.x - 10f, a.x + 10f), Random.Range(10, 10), Random.Range(a.z - 10f, a.z + 10f));
            Instantiate(myPrefab, randomPosition, Quaternion.identity);

            randomPosition = new Vector3(Random.Range(a.x - 10f, a.x + 10f), Random.Range(10, 10), Random.Range(a.z - 10f, a.z + 10f));
            Instantiate(myPrefab, randomPosition, Quaternion.identity);

            randomPosition = new Vector3(Random.Range(a.x - 10f, a.x + 10f), Random.Range(10, 10), Random.Range(a.z - 10f, a.z + 10f));
            Instantiate(myPrefab, randomPosition, Quaternion.identity);

            randomPosition = new Vector3(Random.Range(a.x - 10f, a.x + 10f), Random.Range(10, 10), Random.Range(a.z - 10f, a.z + 10f));
            Instantiate(myPrefab, randomPosition, Quaternion.identity);

            randomPosition = new Vector3(Random.Range(a.x - 10f, a.x + 10f), Random.Range(10, 10), Random.Range(a.z - 10f, a.z + 10f));
            Instantiate(myPrefab, randomPosition, Quaternion.identity);
        }
    }
}
