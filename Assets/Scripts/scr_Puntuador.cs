using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_Puntuador : MonoBehaviour
{

    public GameObject Spott;

    public float Puntaje;
    public static float Récord = 0;
    public Text TextoPuntaje;
    public Text TextoRécord;

    public static int Dinero = 0;
    public Text TextoMonedas;
    public bool Perder;
    int A = 1;
    int B = 2;
    int C = 3;
    int D = 4;

    void Start()
    {

        Perder = false;
        TextoRécord.text = Récord + " M";

    }

    void Update()
    {
        if (Spott != null)
        {
            Puntaje = Mathf.Floor(Spott.transform.position.x + 7);
            TextoMonedas.text = Dinero + " $";
        }

        else
        {
            if (!Perder)
            {
                Perder = true;
            }
            if (Perder == true)
            {
                TextoPuntaje.text = Puntaje + " Metros";
                if (Puntaje > Récord)
                {
                    Récord = Puntaje;
                    TextoRécord.text = Récord + " M";
                }
                else
                {
                    TextoRécord.text = Récord + " M";
                }
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D Colisión)
    {
        // Colisión con Monedas (Is Trigger = true) //
        if (Colisión.tag == "tag_Moneda_A")
        {
            Dinero = Dinero + A;
        }
        if (Colisión.tag == "tag_Moneda_B")
        {
            Dinero = Dinero + B;
        }
        if (Colisión.tag == "tag_Moneda_C")
        {
            Dinero = Dinero + C;
        }
        if (Colisión.tag == "tag_Moneda_D")
        {
            Dinero = Dinero + D;
        }
        //
    }
}