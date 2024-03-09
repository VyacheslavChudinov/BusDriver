using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 50f;
    public float turnSpeed = 60f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        if (transform.position.y < -15)
        {
            transform.position = new Vector3(0, 0, 0);
            transform.forward = new Vector3(0, 0, 0);
            transform.up = new Vector3(0, 0, 0);
        } 
        else
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput * forwardInput);
        }

        

        
    }
}
