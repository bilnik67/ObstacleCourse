using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    Rigidbody rb;

    public GameOverScreen gameOverScreen;

    public PlayerMovement playerMovement;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void GameOver()
    {
        playerMovement.InputEnabled = false;
        gameOverScreen.Setup();            
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
            GameOver();
            rb.freezeRotation = false;
        }
    }
}
