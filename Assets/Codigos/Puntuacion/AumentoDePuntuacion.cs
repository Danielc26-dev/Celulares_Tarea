using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class AumentoDePuntuacion : MonoBehaviour
{
    public int score = 0;
    public TMP_Text TextoActual;

    private void Awake()
    {
        InvokeRepeating("IncreaseScore", 1.0f, 0.5f);
    }
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("PuntajeFinal", 0);
    }

    public void IncreaseScore()
    {
        score += 5;
    }

    private void Update()
    {
        TextoActual.text = score.ToString();

    }

    private void OnDisable()
    {
        Finalizar();
    }


    public void Finalizar()
    {
        PlayerPrefs.SetInt("PuntajeFinal", score);
    }
}
