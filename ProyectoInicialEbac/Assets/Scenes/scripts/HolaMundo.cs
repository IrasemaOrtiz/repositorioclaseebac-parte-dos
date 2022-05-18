using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("algo paso");
        Debug.Log("algo paso");
        Debug.LogError("Algo salio muy mal");
        Debug.LogWarning("Algo salio medianamente mal");
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void FixedUpdate()
    {
        Debug.LogWarning("hola desde Fixed Update cada 50 frames");
    }
    private void LateUpdate()
    {
        Debug.Log("hola desde Late Update");
    }
    private void OnEnable()
    {
        Debug.LogWarning("el objeto ha sido habilitado");
    }
    private void OnDisable()
    {
        Debug.LogWarning("el objeto ha sido inhabilitado"); 
    }
}
