using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// destroy prefabs so they don't affect performance
public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30f; // upper limit
    private float lowerBound = -10f; // lower limit
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ( transform) so if prefab crosses the upper limit, destroy it
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        // ( transform) so if prefab crosses the lower limit, destroy it
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
        }
    }
}
