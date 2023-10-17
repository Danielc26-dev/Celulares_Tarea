using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Puntuacion : MonoBehaviour
{
    public int score = 0;
    public TMP_Text TextoPuntaje;
    public TMP_Text TextoRecord;

    private void Start()
    {
        
        score = PlayerPrefs.GetInt("PuntajeFinal");
        TextoRecord.text = PlayerPrefs.GetInt("PuntajeRecord").ToString();
       
    }

    public void Update()
    {
        TextoPuntaje.text = score.ToString();
        ActualizarScore();
    }

  

    public void ActualizarScore()
    {
        if (score > PlayerPrefs.GetInt("PuntajeRecord"))
        {
           PlayerPrefs.SetInt("PuntajeRecord", score);
           
                TextoRecord.text = score.ToString();
        }
    }
}
