using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParteCuatro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Parte cuatro: utilizar un string y una sentencia switch y dependiendo de la palabra cambiar de color

        {
            string color = "Es amarillo";

            switch (color)
            {
                case "Es blanco":

                    Debug.Log("Es blanco");
                    
                    GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    var cubeRenderer = cube.GetComponent<Renderer>();
                    cubeRenderer.material.SetColor("_Color", Color.white);

                    break;

                case "Es negro":

                    Debug.Log("Es negro");

                    GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    var sphereRenderer = sphere.GetComponent<Renderer>();
                    sphereRenderer.material.SetColor("_Color", Color.black);
                    break;

                case "Es amarillo":

                    Debug.Log("Es amarillo");
                    GameObject capsule = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    var capsuleRenderer = capsule.GetComponent<Renderer>();
                    capsuleRenderer.material.SetColor("_Color", Color.yellow);
                    break;
                    
                        default:
                    Debug.Log("Es nada");
                    GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    var cylinderRenderer = cylinder.GetComponent<Renderer>();
                    cylinderRenderer.material.SetColor("_Color", Color.red);
                    break;
            }



        }
    }

  
  
}
