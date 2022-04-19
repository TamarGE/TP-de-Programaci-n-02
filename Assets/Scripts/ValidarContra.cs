using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContra : MonoBehaviour
{
    string contraCorrecta;
    string contraUsuario;
    public Text ingresoUsuario;
    void Start()
    {
        contraCorrecta = "12345";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void validarContraseña()
    {
        contraUsuario = ingresoUsuario.text;
        if (contraUsuario == contraCorrecta)
        {
            Debug.Log("Bienvenid@");
        }
        else
        {
            Debug.Log("Contraseña incorrecta");
        }
    }
}
