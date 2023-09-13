using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{

    public GameObject Door;

    public bool isCollideWithSphere = false;
    public bool isCollideWithCube = false;
    public bool isCollideWithPyramid = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sphere"))
        {
            isCollideWithSphere = true;
            Debug.Log("Sphere - OK " + isCollideWithSphere);
        }

        if (collision.gameObject.CompareTag("Cube"))
        {
            isCollideWithCube = true;
            Debug.Log("Cube - OK " + isCollideWithCube);
        }

        if (collision.gameObject.CompareTag("Pyramide"))
        {
            isCollideWithPyramid = true;
            Debug.Log("Pyramide - OK " + isCollideWithPyramid);
        }

        if (isCollideWithCube && isCollideWithPyramid && isCollideWithSphere)
        {
            Door.SetActive(false);
            Debug.Log("Door deactivated!");
        }
    }
}
