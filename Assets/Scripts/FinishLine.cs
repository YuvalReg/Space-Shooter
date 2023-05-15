using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] ParticleSystem FinishEffect;
    [SerializeField] AudioSource audioSource;

private void OnTriggerEnter2D(Collider2D other)
{
    audioSource = GetComponent<AudioSource>();
    if (other.tag == "Player")
    {
        FinishEffect.Play();
        audioSource.Play();
        Debug.Log("You Finished!");
        Invoke ("reloadScene", 1.5f);
    }
}

void reloadScene ()
{
    SceneManager.LoadScene(0);
}
}

