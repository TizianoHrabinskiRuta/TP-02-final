using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ClickHandler : MonoBehaviour
{

    public Text ContraseniaIngresada; //Referencia al texto del InputField
    public Text MessageText; // Referencia al texto del cartel que dice si puso bien la contraseña o no
    public GameObject CartelitoDeMensaje; // Referencia al panel del cartel previamente mencionado
    static string ContraseniaCorrecta = "12345";
    

    // Start is called before the first frame update
    void Start()
    {
        CartelitoDeMensaje.SetActive(false);
    }

    public void ValidarContrasenia()
    {
        if(ContraseniaIngresada.text == ContraseniaCorrecta)
        {
            MessageText.text = "Contraseña correcta";
           
            CartelitoDeMensaje.SetActive(true);

            return;
        }

        MessageText.text = "Contraseña incorrecta";
        CartelitoDeMensaje.SetActive(true);
       
    }

    // Update is called once per frame
    void Update()
    {}
}
