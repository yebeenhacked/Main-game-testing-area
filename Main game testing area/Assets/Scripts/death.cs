using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    private float dead = 0f;
    public int points = 0;
    public MouseLook mouse;
    private Renderer render;
    // Update is called once per frame
    private void Start()
    {
        mouse = GameObject.Find("Player").GetComponent<MouseLook>();
        render = GetComponent<Renderer>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (render.isVisible)
            {
                Destroy(transform.parent.gameObject);
            }
        }

        dead += 1f * Time.deltaTime;
        Debug.Log(dead);
        if (dead >= 7)
        {
            Destroy(transform.parent.gameObject);
        }

        
    }
    private void OnDestroy()
    {
        mouse.score += points;
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Player")
        {
            Destroy(transform.parent.gameObject);
        }
    }
    
        
    
}
