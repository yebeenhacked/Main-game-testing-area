using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class currentWeapon : MonoBehaviour
{
    public int slectedWeapon = 1;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(slectedWeapon >= transform.childCount)
            {
                slectedWeapon = 1;
            }
            else
            {
                slectedWeapon++;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            slectedWeapon = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            slectedWeapon = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            slectedWeapon = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            slectedWeapon = 4;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            slectedWeapon = 5;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            slectedWeapon = 6;
        }
        switchWeapon();

    }

    void switchWeapon()
    {
        int i = 1;
        foreach (Transform a in transform)
        {
            if (i == slectedWeapon)
            {
                a.gameObject.SetActive(true);
            }
            else
            {
                a.gameObject.SetActive(false);
            }
            i++;

        }
    }
}
