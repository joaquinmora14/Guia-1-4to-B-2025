using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculos : MonoBehaviour
{
    public int numero1;
    public int numero2;
    public int resultado;
    // Start is called before the first frame update
    void Start()
    {
        resultado = numero1 + numero2;
        Debug.Log("El resultado es " + resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
