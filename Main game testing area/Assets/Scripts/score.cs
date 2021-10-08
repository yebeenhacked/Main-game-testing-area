using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public MouseLook a;
    public Text text;
    private void Update()
    {
        a = GameObject.Find("Player").GetComponent<MouseLook>();
        text.text = a.score.ToString();

    }
}
