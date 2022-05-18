using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Primero : MonoBehaviour
{
    //4)En el primer GO crea una variable booleana que se modifique cada
    //FixedUpdate, si su valor era falso, vuélvelo verdadero y viceversa,
    //pon el color del GO blanco cuando sea verdadero y negro cuando sea falso.

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

