using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perrito_Movimiento : MonoBehaviour
{
    public float levitateSpeed = 1.0f; // Velocidad de levitación.
    public float levitateHeight = 1.0f; // Altura máxima de levitación.

    private Vector3 initialPosition;

    void Start()
    {
        // Almacena la posición inicial del objeto.
        initialPosition = transform.position;
    }

    void Update()
    {
        // Calcula la posición vertical basada en un movimiento sinusoidal.
        float verticalPosition = initialPosition.y + Mathf.Sin(Time.time * levitateSpeed) * levitateHeight;

        // Actualiza la posición del objeto.
        transform.position = new Vector3(transform.position.x, verticalPosition, transform.position.z);
    }
}
