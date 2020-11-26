using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Monedero : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {

    }
    public void OnTriggerEnter2D(Collider2D Colisión)
    {
        // Toca al personaje //
        if (Colisión.gameObject.tag == "tag_Spott")
        {
            Destroy(this.gameObject);
        }
        //
    }
}