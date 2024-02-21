using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerScript : MonoBehaviour
{
    //Rotation Arguments
    [SerializeField] float xAngle = 0;
    [SerializeField] float yAngle = 0;
    [SerializeField] float zAngle = 0;

    new Transform transform;

    void Start()
    {
        transform = GetComponent<Transform>();
    }
    void Update()
    {
        //Keep rotating spinner clockwise
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
