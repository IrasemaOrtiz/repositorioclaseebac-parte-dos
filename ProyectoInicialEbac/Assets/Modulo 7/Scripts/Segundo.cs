using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Segundo : MonoBehaviour
{
    //5)En el segundo GO realiza lo mismo.

    public bool variableB;

    void FixedUpdate()
    {
        if (variableB)
            GetComponent<MeshRenderer>().material.color = new Color(255f, 255f, 255f);
        else
            GetComponent<MeshRenderer>().material.color = new Color(0f, 0f, 0f);

        variableB = !variableB;
    }
}
