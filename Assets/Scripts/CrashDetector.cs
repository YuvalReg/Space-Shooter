using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem CrashEffect;
    [SerializeField] AudioSource audioSource;
    bool hasCrashed = false;
    private void OnTriggerEnter2D(Collider2D other) {
        audioSource = GetComponent<AudioSource>();
        if( other.tag == "Level" && !hasCrashed ) {
            hasCrashed = true;
            FindObjectOfType<Player>().DiasbleControllAndEffects();
            CrashEffect.Play();
            audioSource.Play();
            Debug.Log("You SUCK!");
            Invoke ("reloadScene", 1.5f);
        }
    }

   void reloadScene ()
    {
    SceneManager.LoadScene(0);
    }
}
