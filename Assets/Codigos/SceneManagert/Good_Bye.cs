using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Good_Bye : MonoBehaviour
{
    public float sceneDuration = 10.0f;

    private float timer = 0.0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= sceneDuration)
        {
            Application.Quit();
        }
    }
}
