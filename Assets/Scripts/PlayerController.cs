using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed= 10.0f;
    public float turnSpeed = 30.0f;
    public float HorizontalInput;
    public float VerticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput= Input.GetAxis("Horizontal");
        VerticalInput= Input.GetAxis("Vertical");

        // Move the vehicle forward
        //transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * VerticalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * HorizontalInput);
    }
}
