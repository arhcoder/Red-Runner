using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scr_Puntero : MonoBehaviour {

    public GameObject Spott;
    public Camera CámaraSpott;
    public GameObject[] Bloques;
    public float Puntero;
    public float Punto = 12f;
    public Text TextoPuntaje;
    public float Puntaje;
    public bool Perder;

    void Start ()
    {
        Puntero = 11.25f;
        Perder = false;
	}

	void Update ()
    {
        if(Spott != null)
        {
            CámaraSpott.transform.position = new Vector3
            (
            Spott.transform.position.x + 7,
            CámaraSpott.transform.position.y,
            CámaraSpott.transform.position.z
            );

            Puntaje = Mathf.Floor(Spott.transform.position.x + 7);
            TextoPuntaje.text = Puntaje + " Metros";
        }
        else
        {
            if(!Perder)
            {
                Perder = true;
            }
            if(Perder == true)
            {
                if (Input.GetKeyDown(KeyCode.R))
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }
            }
        }

        while(Spott != null && Puntero < Spott.transform.position.x + Punto)
        {
            int IndiceBloque = Random.Range(1, Bloques.Length);

            GameObject Bloque = Instantiate(Bloques[IndiceBloque]);
            Bloque.transform.SetParent(this.transform);

            scr_Escenario BloqueColocado = Bloque.GetComponent <scr_Escenario>();

            Bloque.transform.position = new Vector2(Puntero + BloqueColocado.Tamaño, -4.6f);
            Puntero += BloqueColocado.Tamaño;
        }
	}
}