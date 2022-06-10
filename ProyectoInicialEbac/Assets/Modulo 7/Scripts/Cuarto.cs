using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuarto : MonoBehaviour
{
    //8)Duplica el tercer GO y su Script también, a este cuarto GO agrégale el
    //nuevo script duplicado y en este evalúa su valor por un OR denotado por
    //el operador ||.

    public Primero GO1;
    public Segundo GO2;
    public bool variableB;
    void FixedUpdate()
    {
        variableB = GO1.variableB || GO2.variableB;
        if (variableB)
            GetComponent<MeshRenderer>().material.color = new Color(255f, 255f, 255f);
        else
            GetComponent<MeshRenderer>().material.color = new Color(0f, 0f, 0f);
    }
}
