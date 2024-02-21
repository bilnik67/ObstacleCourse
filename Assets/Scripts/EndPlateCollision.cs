using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPlateCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player reached the end!");
            // Make player green = win
            other.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            // TODO: other cool end animations cool!
        }
    }
}
