using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    public string sceneName = "MainMenu";
    private void OnCollisionEnter2D(Collision2D other) 
    {
        SceneManager.LoadScene(sceneName);
    }
}
