using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float carForwardSpeed = 5.5f;
    float carTurnSpeed = 5f;
    float horizontalSpeed;
    float turnSpeed;


     void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        horizontalSpeed = Input.GetAxis("Horizontal");
        turnSpeed = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * carForwardSpeed * Time.deltaTime * turnSpeed);
        transform.Rotate(Vector3.up * carTurnSpeed * Time.deltaTime * horizontalSpeed);
        
    }
}
