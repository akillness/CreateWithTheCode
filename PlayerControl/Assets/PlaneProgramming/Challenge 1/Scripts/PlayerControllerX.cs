using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 20f;
    private float rotationSpeed = 100f;
    private float verticalInput;
    // public float horizonInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        // horizonInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        // transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);

        transform.GetChild(0).Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
