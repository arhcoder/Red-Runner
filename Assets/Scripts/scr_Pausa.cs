using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Pausa : MonoBehaviour
{

    public Canvas CanvasPausa;
    public bool Pausa;
    public GameObject Spott;

    void Start()
    {
        CanvasPausa = GetComponent<Canvas>();
        CanvasPausa.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && Spott != null)
        {
            Pausa = !Pausa;
            CanvasPausa.enabled = Pausa;

            if (Pausa == true)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
        }
    }
}