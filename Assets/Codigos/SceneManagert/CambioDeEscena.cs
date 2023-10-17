using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour
{
    public void CambiodeEscena(string Nombre_Escena)
    {
        SceneManager.LoadScene(Nombre_Escena);
        Time.timeScale = 1f;
    }

    public void ReiniciarValores()
    {
        PlayerPrefs.SetInt("PuntajeRecord", 0);
    }
}
