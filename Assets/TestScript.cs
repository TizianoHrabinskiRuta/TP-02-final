using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{

    public Text Texto1;
    public int Edad;


    // Start is called before the first frame update
    void Start()
    {

        if (Edad < 18)
        {
            Texto1.text = "No es mayor de edad";
        }
        else
        {
            Texto1.text = "Es mayor de edad";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
