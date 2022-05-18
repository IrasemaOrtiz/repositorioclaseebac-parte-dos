using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quinto : MonoBehaviour
{
    //8)Duplica el tercer GO y su Script también, a este cuarto GO agrégale el
    //nuevo script duplicado y en este evalúa su valor por un OR denotado por
    //el operador ||.

    public Tercero GO3;
    public Cuarto GO4;

    void FixedUpdate()
    {
        if (GO3.variableB || GO4.variableB)
            GetComponent<MeshRenderer>().material.color = new Color(255f, 255f, 255f);
        else
            GetComponent<MeshRenderer>().material.color = new Color(0f, 0f, 0f);
    }
}
