using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") {
            Debug.Log("Player Wall Collision");
        }
        
    }
    private void OnCollisionExit(Collision other) {
        if (other.gameObject.tag == "Player") {
            Debug.Log("Wall Collision Exit");
        }
    }
}
