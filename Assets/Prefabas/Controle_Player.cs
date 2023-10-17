using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle_Player : MonoBehaviour
{
    public float velocidad = 5.0f;
    private float minX, maxX, minY, maxY;

    void Start()
    {
        Camera camera = Camera.main;
        float camSize = camera.orthographicSize;
        float aspectRatio = (float)Screen.width / Screen.height;
        float camWidth = camSize * aspectRatio;

        minX = camera.transform.position.x - (camWidth - 1);
        maxX = camera.transform.position.x + (camWidth - 1);
        minY = camera.transform.position.y - (camSize - 0.5f);
        maxY = camera.transform.position.y + (camSize - 0.5f);
    }

    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        mousePosition.x = Mathf.Clamp(mousePosition.x, minX, maxX);
        mousePosition.y = Mathf.Clamp(mousePosition.y, minY, maxY);

        transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
    }
}
