using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //velocidad por fotograma
    private float speed = 20f;
    //
    private float turnSpeed = 10f;
    //variabe to move right or left
    private float horizontalInput;
    //variable to move frontwards or backwards
    private float verticalInput;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(0, 0, 1);
        //Detect the inputs
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //Manual forward movement
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        //Manual lateral movement
        /*
        transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);
        */
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
        
    }
}
