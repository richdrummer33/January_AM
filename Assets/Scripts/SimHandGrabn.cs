using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimHandGrabn : MonoBehaviour
{
    public GameObject collidingObject; // What we're touching

    public GameObject heldObject; // Remember whjat we're holding

    public GameObject prefabForFun; // FOR FUN ONLY

    public Animator handAnimator; // Open close hand

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Rigidbody>() == true) // If this object we touch as a Rigidbody (physics object)
        {
            collidingObject = other.gameObject; // Taking note of what we're touching, so we can grab it on mouse click
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == collidingObject) // Check we exited the "colliding oibject" and not some other object
        {
            collidingObject = null; // "Forget" that object
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Grab inputs
        if (Input.GetKeyDown(KeyCode.Mouse0)) // Check ouse input
        {
            if (collidingObject != null) // If collidingObject exists (null = empty)
            {
                Grab();
            }

            handAnimator.SetBool("IsClosed", true); // Close the hand
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            if(heldObject != null) // If heldObject exists (null = empty)
            {
                Release();
            }

            handAnimator.SetBool("IsClosed", false);
        }
        
        // FOR FUN ONLY
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            Instantiate(prefabForFun, transform.position, transform.rotation);
        }
    }

    void Grab()
    {
        collidingObject.GetComponent<Rigidbody>().isKinematic = true; // Not respond to gravity + forces

        collidingObject.transform.parent = transform; // "transform" is this hand

        heldObject = collidingObject; // To remember what we are holding
    }

    void Release()
    {
        heldObject.GetComponent<Rigidbody>().isKinematic = false;

        heldObject.transform.parent = null; // unparent

        heldObject = null; // "Forget" what we were just holding 
    }
}
