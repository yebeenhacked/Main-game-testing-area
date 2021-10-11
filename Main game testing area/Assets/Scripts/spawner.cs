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
    private float waves = 2;
    public int currentWave = -5;
    private int dif = 1;
    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentWave);
        locate = GetComponent<gen>();

        if (transform.childCount <= 0 && currentWave < waves )
        {
            
            
            for (int i = 1; i <= dif; i++)
            {
                spawn(en1, locate);
                spawn(en2, locate);
                spawn(en3, locate);
                spawn(en4, locate);
                spawn(en5, locate);
                spawn(en6, locate);
            }
            dif++;
            currentWave++;
        }
    }

    void spawn(GameObject myPrefab, gen a)
    {
        var randomPosition = new Vector3(Random.Range((a.xsize/2) - 20, (a.xsize/2)+20), Random.Range(10, 10), Random.Range((a.zsize / 2) - 20, (a.zsize / 2) + 20));
        var enemy = Instantiate(myPrefab, randomPosition, Quaternion.identity);
        enemy.transform.parent = gameObject.transform;
    }
}
