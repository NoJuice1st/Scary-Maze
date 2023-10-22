using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    private void OnCollisionStay2D(Collision2D other) 
    {
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene("Level1");
        }
    }
}
