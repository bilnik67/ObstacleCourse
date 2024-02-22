using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class MoveObjectOnYAxis : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float distance = 10f;
    private Vector3 startingPosition;
    [SerializeField] private bool movingForward = true;

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
        StartCoroutine(MoveBackAndForth());
    }

    System.Collections.IEnumerator MoveBackAndForth()
    {
        while (true)
        {
            // Calculate target position
            Vector3 targetPosition = startingPosition + (movingForward ? new Vector3(0, distance, 0) : new Vector3(0, -distance, 0));
            // Move towards the target position
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

            // Check if the object has reached the target position
            if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
            {
                // Switch direction
                movingForward = !movingForward;
                // Wait for a moment before moving back
                yield return new WaitForSeconds(1);
            }
            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
