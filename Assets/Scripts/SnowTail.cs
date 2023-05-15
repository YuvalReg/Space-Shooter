using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowTail : MonoBehaviour
{
    [SerializeField] ParticleSystem particalSystem;
    // Start is called before the first frame update
    void Start()
    {
        particalSystem = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Level") {
            particalSystem.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Level")
        {
            particalSystem.Stop();
        }   
    }
}
