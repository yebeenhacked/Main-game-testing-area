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
    private float waves = 2;
    public int currentWave = -5;
    private int dif = 1;
    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentWave);
        

        if (transform.childCount <= 0 && currentWave < waves )
        {
            
            
            for (int i = 1; i <= dif; i++)
            {
                spawn(en1);
                spawn(en2);
                spawn(en3);
                spawn(en4);
                spawn(en5);
                spawn(en6);
            }
            dif++;
            currentWave++;
        }
    }

    void spawn(GameObject myPrefab)
    {
        var randomPosition = new Vector3(Random.Range((250/2) - 20, (250/2)+20), Random.Range(10, 10), Random.Range((250 / 2) - 20, (250 / 2) + 20));
        var enemy = Instantiate(myPrefab, randomPosition, Quaternion.identity);
        enemy.transform.parent = gameObject.transform;
    }
}
