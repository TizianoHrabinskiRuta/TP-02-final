using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ClickHandler : MonoBehaviour
{

    public Text ContraseniaIngresada;
    
     static string ContraseniaCorrecta = "12345";
    

    // Start is called before the first frame update
    void Start()
    {
        

    }

    public void ValidarContrasenia()
    {
        

         if(ContraseniaIngresada.text == ContraseniaCorrecta)
        {
            Debug.Log("bienvenido manito");
            return;
        }

        Debug.Log("no, largo de aca");

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
