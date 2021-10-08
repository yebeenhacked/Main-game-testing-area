using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class currentWeapon : MonoBehaviour
{
    public int slectedWeapon;
    
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
