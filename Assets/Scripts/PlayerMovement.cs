using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float PlayerMoveSpeed = 10f;

    public bool isGrounded = false;

    public bool InputEnabled = true;

    // Start is called before the first frame update
    void Start()
    {
        isGrounded = false;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
    void MovePlayer()
    {
        if (!InputEnabled)
        {
            return;
        }
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(xInput, 0, yInput) * PlayerMoveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space) && isGrounded == true)
        {
            transform.Translate(Vector3.up * PlayerMoveSpeed * Time.deltaTime);
        }
    }

    public void EnableInput()
    {
        InputEnabled = true;
    }

    public void DisableInput()
    {
        InputEnabled = false;
    }

}
