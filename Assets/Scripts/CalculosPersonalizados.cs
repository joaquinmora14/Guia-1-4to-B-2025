using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculosPersonalizados : MonoBehaviour
{
    public float numero1;
    public float numero2;
    float resultado;

    // Start is called before the first frame update
    void Start()
    {
        resultado = numero1 + numero2;
        Debug.Log("El resultado de la suma entre " + numero1 + " y " + numero2 + " es " + resultado);
        resultado = numero1 - numero2;
        Debug.Log("El resultado de la resta entre " + numero1 + " y " + numero2 + " es " + resultado);
        resultado = numero1 * numero2;
        Debug.Log("El resultado de la multiplicacion entre " + numero1 + " y " + numero2 + " es " + resultado);
        resultado = numero1 / numero2;
        Debug.Log("El resultado de la division entre " + numero1 + " y " + numero2 + " es " + resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
