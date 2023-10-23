using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpScare : MonoBehaviour
{
    public GameObject jumpScare;
    public GameObject retryBtn;
    public AudioSource scareSound;
    public GameObject level;
    private void OnCollisionEnter2D(Collision2D other) 
    {
        level.SetActive(false);
        jumpScare.SetActive(true);
        scareSound.Play();

        Invoke("ShowRetryButton", 1f);
    }

    void ShowRetryButton()
    {
        retryBtn.SetActive(true);
    }
}
