using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // other is the object that the player collided with
    private void OnCollisionEnter(Collision other)
    {
        // exclude base
        if (other.gameObject.tag == "Ground" || other.gameObject.tag == "EndPlate" || other.gameObject.tag == "StartPlate")
        {
            // Do nothing when player collides with any of these tags
        }
        else{
            Debug.Log("Player collided with obstacle!");
            // Make player red = die
            GetComponent<MeshRenderer>().material.color = Color.red;
            rb.freezeRotation = false;
        }
    }
}
