using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MayorEdad : MonoBehaviour
{
    public int edadUsuario;
    public Text MiTexto;
    void Start()
    {
        if (edadUsuario >= 18)
        {
            MiTexto.text = "Es mayor de edad";
            Debug.Log("Es mayor de edad");
        }
        else
        {
            MiTexto.text = "No es mayor de edad";
            Debug.Log("No es mayor de edad");
        }
    }

}
