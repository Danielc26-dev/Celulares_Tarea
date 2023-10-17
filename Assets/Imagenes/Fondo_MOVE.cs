using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fondo_MOVE : MonoBehaviour
{
    public Vector2 velocidad = new Vector2(1.0f, 0.0f);
    public Texture2D textura2D;

    private Material material;
    private Vector2 offsetInicial;

    void Start()
    {

        Renderer renderer = GetComponent<Renderer>();
        material = renderer.material;

        offsetInicial = material.GetTextureOffset("_MainTex");

        material.SetTexture("_MainTex", textura2D);
    }

    void Update()
    {
        Vector2 offset = offsetInicial + velocidad * Time.time;

        material.SetTextureOffset("_MainTex", offset);
    }
}
