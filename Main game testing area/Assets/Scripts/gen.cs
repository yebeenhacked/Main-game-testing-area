using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshCollider))]
public class gen : MonoBehaviour
{
    private const int Z = 1;
    Mesh mesh;
    public int xsize = 20;
    public int zsize = 20;

    Vector3[] verticies;
    int[] triangles;
    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        createShape();
        updateMesh();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void createShape()
    {
        verticies = new Vector3[(xsize + 1) * (zsize + 1)];


        for (int i = 0, z = 0; z <= zsize; z++)
        {
            for (int x = 0; x <= zsize; x++)
            {
                float y = Mathf.PerlinNoise(x*.1f, z*.1f);
                verticies[i] = new Vector3(x, y, z);
                i++;
            }
        }

        triangles = new int[xsize * zsize *6];
        int vert = 0;
        int tris = 0;

        for (int z = 0; z < zsize; z++)
        {
            for (int x = 0; x < xsize; x++)
            {

                triangles[tris + 0] = vert + 0;
                triangles[tris + 1] = vert + xsize + 1;
                triangles[tris + 2] = vert + 1;
                triangles[tris + 3] = vert + 1;
                triangles[tris + 4] = vert + xsize + 1;
                triangles[tris + 5] = vert + xsize + 2;

                vert++;
                tris += 6;
            }
            vert++;
        }

        
    }

    void updateMesh()
    {
        mesh.Clear();

        mesh.vertices = verticies;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
        mesh.RecalculateBounds();
        MeshCollider meshCollider = gameObject.GetComponent<MeshCollider>();
        meshCollider.sharedMesh = mesh;
    }

    private void OnDrawGizmos()
    {
        if (verticies == null)
        {
            return;
        }
        for(int i = 0; i< verticies.Length; i++)
        {
            Gizmos.DrawSphere(verticies[i], .1f);
        }
    }
}
