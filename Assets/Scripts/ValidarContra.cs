using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContra : MonoBehaviour
{
    string contraCorrecta;
    string contraUsuario;
    public Text ingresoUsuario;
    public GameObject Cartelito;
    public Text textoMsj;
    void Start()
    {
        contraCorrecta = "12345";
        Cartelito.SetActive(false);
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
            Cartelito.SetActive(true);
            textoMsj.text = "Bienvenid@";
            //Debug.Log("Bienvenid@");
        }
        else
        {
            Cartelito.SetActive(true);
            textoMsj.text = "Contraseña incorrecta";
           //Debug.Log("Contraseña incorrecta");
        }
    }
}
