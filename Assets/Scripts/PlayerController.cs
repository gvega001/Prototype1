using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private Variables
    private float speed = 5.0f;
    private float turnSpeed= 25.0f;
    private float horizontalInput;
    private float forwaredInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        //This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwaredInput = Input.GetAxis("Vertical");

        //We will make the car move forware on update
        transform.Translate(Vector3.forward * Time.deltaTime * speed *forwaredInput);
        //We turn the vehicle
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
     
    }
}
