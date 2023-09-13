using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollisionDetection : MonoBehaviour
{
    public bool isCollideWithCube = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube") && !isCollideWithCube)
        {
            isCollideWithCube = true;
            Debug.Log("Cube: " + isCollideWithCube);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        isCollideWithCube = false;
    }
}
