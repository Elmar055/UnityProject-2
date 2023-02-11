using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput; 
    private float speed = 30f; // Right-to-left movement speed along the x-axis
    private float xRange = 15f; // max limit in x-axis

    // food object that is, the object we want to create a copy of
    public GameObject projectilePrefab; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // left right movement keys
        horizontalInput = Input.GetAxis("Horizontal"); 

        // left right movement
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

        // max limit code x-axis
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange,transform.position.y,transform.position.z);
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        // Create a clone of an object(projectilePrefab) when space is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab,transform.position,projectilePrefab.transform.rotation);
        }
    }
}
