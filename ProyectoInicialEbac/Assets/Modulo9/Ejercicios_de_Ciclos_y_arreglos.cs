using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios_de_Ciclos_y_arreglos : MonoBehaviour
{
    void Start()
    {
        //1) Crea dos arreglos unidimensionales de números enteros y llenalos
        //usando un ciclo y la función Random.Range con números enteros,
        //después crea un tercer arreglo y llénalo con la suma de los elementos
        //de los primeros dos: por ejemplo arr3[5] = arr1[5] + arr[6]
        int longitud = Random.Range(4, 9);
        int[] arr1 = new int[longitud];
        int[] arr2 = new int[longitud];
        int[] arr3 = new int[longitud];
        string a = "", b = "", c = "";

        for (int i = 0; i < longitud; i++)
        {
            arr1[i] = Random.Range(0, 9);
            a += arr1[i] + " ";
            arr2[i] = Random.Range(0, 9);
            b += arr2[i] + " ";
            arr3[i] = arr1[i] + arr2[i];
            c += arr3[i] + " ";
        }
        //Visualización en consola
        Debug.Log("1)\n" + a + "  +  " + b + "  =  " + c);


        //2) Crea un arreglo de strings y llena cada elemento con una palabra de
        //una oración, después utilizando un ciclo foreach concatena sus elementos
        //e imprime la oración completa en la consola en un solo string.
        string[] desarmada = new string[] { "Esta ", "es ", "una ", "oración ", "completa." };
        string armada = "";

        foreach (string item in desarmada)
            armada += item;

        //Visualización en consola
        Debug.Log("2)\n" + armada);


        //3) Crea un arreglo bidimensional de enteros de 2 renglones y 3 columnas
        //al menos y multiplícalo por un arreglo unidimensional de enteros con
        //la cantidad de elementos que se alinee a la cantidad de renglones del
        //arreglo bidimensional de tal manera que la operación sea una multiplicación
        //matriz* vector que da como resultado un arreglo unidimensional descrito
        int[,] bidimensional = new int[,] { { 2, 1, 5 }, { 1, 3, 6 }, { 1, 2, 4 } };
        int[] unidimensional = new int[] { 3, 5, 1};
        int[] multiplicado = new int[3];
        string res = "";
        for (int fila = 0; fila < 3; fila++) {
            for (int columna = 0; columna < 3; columna++){
                multiplicado[fila] += bidimensional[fila, columna] * unidimensional[columna];
            }
            res += multiplicado[fila] + " ";
        }
        //Visualización en consola
        Debug.Log(res);
    }
}