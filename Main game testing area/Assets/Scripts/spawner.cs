using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject en1;
    public GameObject en2;
    public GameObject en3;
    public GameObject en4;
    public GameObject en5;
    public GameObject en6;
    private float time = 7f;
    // Update is called once per frame
    void Update()
    {
        time += 1f * Time.deltaTime;

        if (time >= 7)
        {
            time = 0;
            Vector3 locate = transform.position;
            spawn(en1,locate);
            spawn(en2, locate);
            spawn(en3, locate);
            spawn(en4, locate);
            spawn(en5, locate);
            spawn(en6, locate);
        }
    }

    void spawn(GameObject myPrefab, Vector3 a)
    {
        var randomPosition = new Vector3(Random.Range(a.x - 10f, a.x + 10f), Random.Range(10, 10), Random.Range(a.z - 10f, a.z + 10f));
        Instantiate(myPrefab, randomPosition, Quaternion.identity);
    }
}
