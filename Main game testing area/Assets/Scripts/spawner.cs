using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    gen locate;
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
        locate = GetComponent<gen>();

        if (time >= 7)
        {
            time = 0;
            spawn(en1,locate);
            spawn(en2, locate);
            spawn(en3, locate);
            spawn(en4, locate);
            spawn(en5, locate);
            spawn(en6, locate);
        }
    }

    void spawn(GameObject myPrefab, gen a)
    {
        var randomPosition = new Vector3(Random.Range((a.xsize/2) - 20, (a.xsize/2)+20), Random.Range(10, 10), Random.Range((a.zsize / 2) - 20, (a.zsize / 2) + 20));
        Instantiate(myPrefab, randomPosition, Quaternion.identity);
    }
}
