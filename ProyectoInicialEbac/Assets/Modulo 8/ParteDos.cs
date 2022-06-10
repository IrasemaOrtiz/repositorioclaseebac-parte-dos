using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParteDos : MonoBehaviour
{
    private const string V = "es par";
   

    // Start is called before the first frame update
    void Start()
    {
        //Parte uno
        
        int valorEntero = 2300;
        char caracter = '3';
        int valorCaracter = 0;

        if (!int.TryParse(caracter.ToString(), out valorCaracter))
        {
            Debug.LogError(valorEntero + valorCaracter);
        }

        Debug.Log(valorEntero+valorCaracter);

        int otroValorEntero = 1254;
        char otroCaracter = '8';
        int otroValorCaracter = 0;

        if(!int.TryParse(otroCaracter.ToString(), out otroValorCaracter))
        {
            Debug.Log(otroValorEntero + otroValorCaracter);
        }
        else
        {
            Debug.Log(otroValorEntero + otroValorCaracter);
        }


        //Parte Dos


        int miCaracter;
        string miString = "Hola Mundo";
        int longitud = miString.Length;
        Debug.Log(longitud);

        miCaracter = Random.Range(0, 10);
        if (miCaracter % 2 == 0)
        {
            Debug.Log("el numero par" + miCaracter + "o,a, M, n, o");
        }
        else
        {
            Debug.Log("el numero es non" + miCaracter + "H, l, u, d ");
        }
        

        //Parte Tres
        string misApellidos = "VazquezOrtiz";
        string primerApellido = misApellidos.Remove(0, 5);
        Debug.Log(primerApellido);

    }

    
}
