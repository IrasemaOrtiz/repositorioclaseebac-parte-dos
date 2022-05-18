using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeCrear : MonoBehaviour
{
    public GameObject prefab;
    float x;
    float y;
    float z;
    Vector3 nuevaPosicion;
    void Awake()
    {
        x = Random.Range(-5, 5);
        y = 10;
        z = Random.Range(-5, 5);
        nuevaPosicion = new Vector3(x, y, z);
        GameObject nuevo = Instantiate(prefab, nuevaPosicion, Quaternion.identity);
        nuevo.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }


}
