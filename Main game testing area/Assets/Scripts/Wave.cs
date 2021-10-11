using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wave : MonoBehaviour
{
    public spawner spawn;
    public Text text;
    private void Update()
    {
        spawn = GameObject.Find("terrain").GetComponent<spawner>();
        text.text = "Current Wave: "+ spawn.currentWave.ToString();

    }
}
