using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManagerScript : MonoBehaviour
{
    
    private void Awake()
    {
        SceneManager.LoadScene("Goblal_Scene_Manager", LoadSceneMode.Additive);        
    }
}
