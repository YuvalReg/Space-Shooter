using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _torqueAmount = 1f;
    [SerializeField] private float _effectorSpeedDefult= 10f;
    [SerializeField] private float _effectorSpeedMax= 20f;
    bool isAlive = true;
    Rigidbody2D rb2d;
    SurfaceEffector2D se2d;

    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        se2d = GameObject.FindWithTag("Level").GetComponent<SurfaceEffector2D>();
        se2d.speed = _effectorSpeedDefult;
        
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        SpeedController();
    }
    public void DiasbleControllAndEffects()
    {
        isAlive = false;
    }

    private void RotatePlayer() {

        if (isAlive)
        {
            if(Input.GetKey(KeyCode.LeftArrow))
            {
            rb2d.AddTorque( _torqueAmount );
            }

            else if(Input.GetKey(KeyCode.RightArrow))
            {
            rb2d.AddTorque( -_torqueAmount );
            }
        }    
    }

    private void SpeedController() {

        if (isAlive)
        {
            if(Input.GetKey(KeyCode.UpArrow))
            {
            se2d.speed = _effectorSpeedMax;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
            se2d.speed = 0;
            }
            else { se2d.speed = _effectorSpeedDefult; }
        }
    }
}

