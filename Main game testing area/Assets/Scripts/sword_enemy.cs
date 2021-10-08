using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword_enemy : MonoBehaviour
{
    public GameObject myPrefab;
    private bool isQuitting = false;
    private float mSize = 0f;
    private Renderer render;
    private MouseLook a;
    // Start is called before the first frame update
    private void Start()
    {
        render = GetComponent<Renderer>();
        a = GameObject.Find("Player").GetComponent<MouseLook>();
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) )
        {
            if (render.isVisible)
            {
                
                Destroy(this.gameObject);
                
            }
        }




    }
    void OnApplicationQuit()
    {
        isQuitting = true;
    }

    /*private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            InvokeRepeating("Scale", 0f, .003f);


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

        if (mSize >= .50)
        {
            CancelInvoke("Scale");
        }


        GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(0, mSize++);
    }

    */

    private void OnDestroy()
    {

        if (!isQuitting) {
            
            Vector3 a = transform.position;
            var randomPosition = new Vector3(Random.Range(a.x - .5f, a.x + .5f),.1f, Random.Range(a.z - .5f, a.z + .5f));
            Instantiate(myPrefab, randomPosition, Quaternion.identity);

            randomPosition = new Vector3(Random.Range(a.x - .5f, a.x + .5f),.1f, Random.Range(a.z - .5f, a.z + .5f));
            Instantiate(myPrefab, randomPosition, Quaternion.identity);

            randomPosition = new Vector3(Random.Range(a.x - .5f, a.x + .5f),.1f, Random.Range(a.z - .5f, a.z + .5f));
            Instantiate(myPrefab, randomPosition, Quaternion.identity);

            randomPosition = new Vector3(Random.Range(a.x - .5f, a.x + .5f),.1f, Random.Range(a.z - .5f, a.z + .5f));
            Instantiate(myPrefab, randomPosition, Quaternion.identity);

            randomPosition = new Vector3(Random.Range(a.x - .5f, a.x + .5f),.1f, Random.Range(a.z - .5f, a.z + .5f));
            Instantiate(myPrefab, randomPosition, Quaternion.identity);
        }
    }
}