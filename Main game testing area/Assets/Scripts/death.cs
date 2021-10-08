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
                Destroy(this.gameObject);
            }
        }

        dead += 1f * Time.deltaTime;
        
        if (dead >= 7)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnDestroy()
    {
        mouse.score += points;
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
