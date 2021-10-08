using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    private Camera _camera;
    private Ray _ray;
    private RaycastHit _rayhit;

    // Start is called before the first frame update
    void Start()
    {
        _camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shootray();
        }
    }





    private void shootray()
    {
        _ray = _camera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        
        if (Physics.Raycast(_ray, out _rayhit))
        {
            if(_rayhit.collider.gameObject.name != "Plane" && _rayhit.collider.gameObject.name != "Player")
            {
                Destroy(_rayhit.collider.gameObject);
            }
            

        }
    }
}
