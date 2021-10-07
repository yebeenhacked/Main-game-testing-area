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
        _ray = _camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(_ray, out _rayhit))
        {
            Debug.Log(_rayhit.transform.name);

        }
    }
}
