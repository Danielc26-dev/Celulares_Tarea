using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nuevo Personaje", menuName = "Personaje")]

public class Personaje_INfo : ScriptableObject
{
    public GameObject personajeJugable;
    public Sprite Imagen;
    public string nombre; 
}
