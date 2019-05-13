using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadDatas : MonoBehaviour
{
    public SaveSO datos;
    int[] elementos;
    int numAños;
    public Text final;



    void Start()
    {
        print(datos.años + datos.elementos.Length);
        numAños = datos.años;
        elementos = datos.elementos;
        final.text = "Has muerto a la edad de " + numAños + " años";
        recorrer();
    }

    public void recorrer()
    {
        //Se comprueban los arrays
    }

   

}
