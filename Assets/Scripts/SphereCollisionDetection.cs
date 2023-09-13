using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpheresCollisionDetection : MonoBehaviour
{
    public bool isCollideWithSphere = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sphere") && !isCollideWithSphere)
        {
            isCollideWithSphere = true;
            Debug.Log("Sphere: " + isCollideWithSphere);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        isCollideWithSphere = false;
    }
}
