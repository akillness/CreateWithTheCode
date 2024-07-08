using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 18.0f;

    public GameObject projecttilePrefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange,transform.position.y,transform.position.z);
        }else if( transform.position.x > xRange )
        {
            transform.position = new Vector3(xRange,transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from player
            Instantiate(projecttilePrefabs,transform.position,projecttilePrefabs.transform.rotation);
        }
    }
}
