using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    private float dead = 0f;
    public MouseLook mouse;

    // Update is called once per frame
    private void Start()
    {
        mouse = GameObject.Find("Player").GetComponent<MouseLook>();
    }
    void Update()
    {
        dead += 1f * Time.deltaTime;
        
        if (dead >= 7)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnDestroy()
    {
        mouse.score += 10;
        Debug.Log(mouse.score);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Player")
        {
            Destroy(this.gameObject);
        }
    }
    
        
    
}
