using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimHandGrabn : MonoBehaviour
{
    public GameObject collidingObject; // What we're touching

    public GameObject heldObject; // Remember whjat we're holding

    public GameObject prefabForFun; // FOR FUN ONLY

    private void OnTriggerEnter(Collider other)
    {
        collidingObject = other.gameObject; // Taking note of what we're touching, so we can grab it on mouse click
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == collidingObject) // Check we exited the "colliding oibject" and not some other object
        {
            collidingObject = null; // "Forget" that object
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Grab inputs
        if (Input.GetKeyDown(KeyCode.Mouse0)) // Check ouse input
        {
            // Perform a grab
        }

        // FOR FUN ONLY
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            Instantiate(prefabForFun, transform.position, transform.rotation);
        }
    }
}
