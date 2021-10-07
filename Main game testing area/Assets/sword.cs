using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{

    private float mSize = 0f;
    // Start is called before the first frame update
    void Start()
    {


        


    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            InvokeRepeating("Scale",0f , .01f);
            
            
        }
        if (mSize >= 99)
        {
            CancelInvoke("Scale");
            mSize = 0;
            GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(0, mSize);
        }
    }

    void Scale()
    {

        if(mSize >= 100)
        {
            CancelInvoke("Scale");
        }


        GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(0,mSize++);
    }



}
