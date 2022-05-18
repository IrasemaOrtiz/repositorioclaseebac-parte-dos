using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarAwake : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Awake()
    {
        for(var i = 0; i < 10; i++)
        Instantiate(prefab, new Vector3(i * 2.0f, 0, 0), Quaternion.identity);
        prefab.AddComponent<MeshFilter>();
        var meshfilter = prefab.GetComponent<MeshFilter>().mesh;
        meshfilter.Clear();
        meshfilter.Optimize();
        meshfilter.RecalculateNormals();
        prefab.AddComponent<BoxCollider>();
        var boxCollider = prefab.GetComponent<BoxCollider>();
        
        prefab.AddComponent<MeshRenderer>();
        var MeshRendererMaterial = prefab.GetComponent<MeshRenderer>().material;
        MeshRendererMaterial.color = Color.red;
        prefab.transform.position = Vector3.one;

    }

   
}
