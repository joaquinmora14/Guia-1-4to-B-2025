using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComidaDeAnimalitos : MonoBehaviour
{

    //1. definición de variables
    public int cantidadDeDias;
    public string codigoAnimal;
    int gramosComidaTotal;
    int racionGatos = 300;
    int racionPerrosPeque = 400;
    int racionPerrosGrandes = 700;
    int racionAnimalActual;
    float costoAlimento;
    float precioPorCienGramos = 80;

    // Start is called before the first frame update
    void Start()
    {
        //2. Ingreso de datos (más adelante)}
        if(codigoAnimal == "G" || codigoAnimal == "g")
        {
      racionAnimalActual * racionGatos;
        }else if (codigoAnimal == "PP" || codigoAnimal == "pp")
         {
      racionAnimalActual * racionPerrosPeque;
      }else if (codigoAnimal == "PG" ||  odigoAnimal == "pg")
         {
      racionAnimalActual * racionPerrosGrandes;
        }

        //3. Procesamiento de los datos

        gramosComidaTotal == racionAnimalActual * cantidadDeDias;

        costoAlimento = gramosComidaTotal/ 100 * precioPorCienGramos
 
        //4. Mostrar el resultado

        Debug.log("Para ese periodo se necesitan " + gramosComidaTotal + " gramos de alimento.");
        Debug.log("Costo de alimento " + costoAlimento);
        
    };

    // Update is called once per frame
    void Update()
    {
        
    }
}
