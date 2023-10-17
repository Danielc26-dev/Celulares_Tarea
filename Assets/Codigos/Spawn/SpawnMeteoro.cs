using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMeteoro : MonoBehaviour
{
    public MeteoroPool meteoroPool;
    public float intervaloSpawn = .0f;
    public Vector2 spawnArea = new Vector2(10.0f, 4.0f);

    private void Start()
    {
        InvokeRepeating("GenerarMeteoro", 0, intervaloSpawn);
    }

    private void GenerarMeteoro()
    {
        float y = Random.Range(-spawnArea.y, spawnArea.y);
        Vector3 posicionSpawn = new Vector3(spawnArea.x, y, 0);

        GameObject meteoro = meteoroPool.ObtenerMeteoro();

        meteoro.transform.position = posicionSpawn;

        meteoro.SetActive(true);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(spawnArea, 0.5f);
    }
}
