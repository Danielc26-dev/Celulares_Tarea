using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perrito_Movimiento : MonoBehaviour
{
    public float levitateSpeed = 1.0f; // Velocidad de levitaci�n.
    public float levitateHeight = 1.0f; // Altura m�xima de levitaci�n.

    private Vector3 initialPosition;

    void Start()
    {
        // Almacena la posici�n inicial del objeto.
        initialPosition = transform.position;
    }

    void Update()
    {
        // Calcula la posici�n vertical basada en un movimiento sinusoidal.
        float verticalPosition = initialPosition.y + Mathf.Sin(Time.time * levitateSpeed) * levitateHeight;

        // Actualiza la posici�n del objeto.
        transform.position = new Vector3(transform.position.x, verticalPosition, transform.position.z);
    }
}
