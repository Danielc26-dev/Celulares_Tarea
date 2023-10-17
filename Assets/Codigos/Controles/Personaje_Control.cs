using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje_Control : MonoBehaviour
{
    public GameObject Pausa;
    private bool Esta_En_Pausa;

    private void Start()
    {
        Esta_En_Pausa = false;
        Pausa.SetActive(false);
    }

    public void Boton_Pausa()
    {
        Pausa.SetActive(Esta_En_Pausa);
        if (Esta_En_Pausa)
        {
            Pausar();
        }
        else
        {
            Reanudar();
        }

        Esta_En_Pausa = !Esta_En_Pausa;
    }
    public void Pausar()
    {
        Time.timeScale = 0f;
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
    }
}
