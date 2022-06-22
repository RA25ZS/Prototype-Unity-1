using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float carSpeed = 2.5f;

     void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * carSpeed * Time.deltaTime);
        
    }
}
