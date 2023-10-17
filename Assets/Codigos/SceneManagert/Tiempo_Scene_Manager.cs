using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tiempo_Scene_Manager : MonoBehaviour
{
    public string sceneToLoad = "GameScene";  
    public float presentationDuration = 5.0f;  
    public Image loadingBar;  
    public Transform startMarker;  
    public Transform endMarker;  
    public float speed = 1.0f; 

    private float timer = 0.0f;
    private float distance;

    void Start()
    {
        distance = Vector3.Distance(startMarker.position, endMarker.position);
    }

    void Update()
    {
        timer += Time.deltaTime;

        float loadProgress = Mathf.Clamp01(timer / presentationDuration);
        loadingBar.fillAmount = loadProgress;

        Vector3 currentPosition = Vector3.Lerp(startMarker.position, endMarker.position, loadProgress);

        loadingBar.transform.position = currentPosition;

        if (timer >= presentationDuration)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    private void OnDrawGizmos()
    {
        if (startMarker != null && endMarker != null)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(startMarker.position, endMarker.position);
        }
    }
}
