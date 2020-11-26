using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_Spott : MonoBehaviour {

    public Animator AnimadorSpott;
    public float FSalto;
    public float VMoviemiento;
    public bool Inicio = false;
    public bool Salto = false;

	void Start ()
    {

    }

	void Update ()
    {
        // Se presiona espacio //
        if (Input.GetKeyDown(KeyCode.Space) && Salto == false)
        {
            Inicio = true;
            AnimadorSpott.SetBool("Inicio", true);
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, FSalto));
        }
        //
        // Si se inicia el juego //
        if (Inicio == true)
        {
            this.GetComponent<Rigidbody2D>().velocity = (new Vector2(VMoviemiento,
            this.GetComponent<Rigidbody2D>().velocity.y));
            AnimadorSpott.SetFloat("VMovimiento", VMoviemiento);
            if(Time.timeScale == 1)
            {
                VMoviemiento = VMoviemiento + 0.0004f;
            }
        }
        //
	}

    //Si contacta con las cajas o con el suelo //
    private void OnCollisionEnter2D(Collision2D ColisiónSuelo)
    {
        Salto = false;
        AnimadorSpott.SetBool("Salto", false);
    }

    private void OnCollisionExit2D(Collision2D ColisiónSuelo)
    {
        Salto = true;
        AnimadorSpott.SetBool("Salto", true);
    }
    //

    public void OnTriggerEnter2D(Collider2D Colisión)
    {
        // Colisión con Flama (Is Trigger = true) //
        if (Colisión.tag == "tag_Flama")
        {
            Destroy(this.gameObject);
        }
        if (Colisión.tag == "tag_Caja")
        {
            Destroy(this.gameObject);
        }
        //
    }
    public void OnTriggerExit2D(Collider2D Colisión)
    {
        Salto = true;
        AnimadorSpott.SetBool("Salto", true);
    }
}