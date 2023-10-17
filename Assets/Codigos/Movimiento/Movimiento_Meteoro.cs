using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimiento_Meteoro : MonoBehaviour
{
    public float velocidad = 5.0f;
    public AumentoDePuntuacion aumento;

    private void Update()
    {
        transform.Translate(Vector3.left * velocidad * Time.deltaTime);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ElFinal"))
        {
            gameObject.SetActive(false);
        }

        if(other.CompareTag("ElPlayer"))
        {
            aumento.Finalizar();
            SceneManager.LoadScene("Puntaje");
        }
    }


}
