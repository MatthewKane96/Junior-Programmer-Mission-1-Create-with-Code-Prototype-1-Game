using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private Variables
    public float speed = 20.0f;
    public float turnspeed;
    //public float turnspeed = 45.0f;
    //public float horizontalInput;
    //private float forwardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Issue with user input below that  causes break and doesn't allow vehicle to move. Resolved
        // Solution : - Go to Edit Menu in Unity, got to project settings, go to the list on the side left click player, expand other setting, scroll down and find configuration and change active input handling to Both

        // This is where we get Player input
        //horizontalInput = Input.GetAxis("Horizontal");
        // forwardInput = Input.GetAxis("Vertical");

        // We Move the vehicle Vertically Forward and back
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        // transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Move the vehicle Horizontally
        transform.Translate(Vector3.right * Time.deltaTime * turnspeed);
        //transform.Translate(Vector3.right * Time.deltaTime * turnspeed * horizontalInput);
        // We Turn the vehicle based on Rotation via horizontal input 
        //transform.Rotate(Vector3.up, turnspeed * horizontalInput * Time.deltaTime);


    }
}