using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tercero : MonoBehaviour
{
    //6)En el tercer GO obtén de los otros 2 GO el valor de sus variables
    //booleanas.
    //7)En el tercer GO el valor de la variable booleana dependerá
    //primero de un AND dado por el operador && evalúa como cambia de color.

    public Primero GO1;
    public Segundo GO2;
    public bool variableB;
    void FixedUpdate()
    {
        variableB = GO1.variableB && GO2.variableB;
        if (variableB)
            GetComponent<MeshRenderer>().material.color = new Color(255f, 255f, 255f);
        else
            GetComponent<MeshRenderer>().material.color = new Color(0f, 0f, 0f);
    }
}
