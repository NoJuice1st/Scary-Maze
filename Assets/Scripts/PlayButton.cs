using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public string sceneName = "Level1";
    private void OnCollisionStay2D(Collision2D other) 
    {
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
