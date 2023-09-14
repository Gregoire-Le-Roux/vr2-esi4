using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyramidCollisionDetection : MonoBehaviour
{
    public bool isCollideWithPyramid = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pyramide") && !isCollideWithPyramid)
        {
            isCollideWithPyramid = true;
            Debug.Log("Pyramide: " + isCollideWithPyramid);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        isCollideWithPyramid = false;
    }
}
