using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParteUno : MonoBehaviour
         
{

    int miEntero = 0;
    float miFloat = 0;
    

    // Parte uno: Crea dos variables de tipo entero, una en cada FX y una en Update
    void FixedUpdate()
    {
        miFloat += 8;
        Debug.Log(miFloat);
    }

   
    void Update()
    {
        miEntero += 9;
        Debug.Log(miEntero);
    }

    //Parte dos: Crear dos variables flotantes
    private void Start()
    {
        float r = 4.8f;
        r /= 2;
        int algunEntero = (int)r;
        Debug.Log(algunEntero);

        float k = 9.8f;
        k += 4;
        int otroAlgunEntero = (int)k;
        Debug.Log(otroAlgunEntero);

        //Parte tres: Crear un operador modulo
        int miOtroOtroEntero;
        miOtroOtroEntero = Random.Range(2, 9);
        if(miOtroOtroEntero % 2 == 0)
        {
            Debug.Log("el numero" + miOtroOtroEntero + "es par");

        }
        else
        {
            Debug.Log("el numero" + miOtroOtroEntero + "es non");
        }

        

        //Parte cinco; Convertir numero flotante a string

        float t = 2.1234567890f;
        t.ToString("n4");
        Debug.Log(t);

        



        //Parte 6: Utilizar substring en 3 strings 
        string phrase = "Irasema Vazquez Ortiz";
        string[] words = phrase.Split(' ');

        foreach (var word in words)
        {
            Debug.Log($"<{word}>");
        }
    }
}
