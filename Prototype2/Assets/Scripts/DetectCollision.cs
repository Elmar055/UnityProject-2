using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// what happens when two objects collide

public class DetectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // if animal and food object collise destroy them
    private void OnTriggerEnter(Collider other)
    {
        //destroys animals
        Destroy(gameObject);
        //destroys food
        Destroy(other.gameObject);
    }
}
