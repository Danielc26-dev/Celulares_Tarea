using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoroPool : MonoBehaviour
{
    public GameObject meteoroPrefab;
    public int cantidadInicial = 10;

    private List<GameObject> meteoros;

    private void Start()
    {
        meteoros = new List<GameObject>();

        for (int i = 0; i < cantidadInicial; i++)
        {
            GameObject meteoro = Instantiate(meteoroPrefab, transform);
            meteoro.SetActive(false);
            meteoros.Add(meteoro);
        }
    }

    public GameObject ObtenerMeteoro()
    {
        foreach (var meteoro in meteoros)
        {
            if (!meteoro.activeInHierarchy)
            {
                meteoro.SetActive(true);
                return meteoro;
            }
        }

        GameObject nuevoMeteoro = Instantiate(meteoroPrefab, transform);
        meteoros.Add(nuevoMeteoro);
        return nuevoMeteoro;
    }
}
