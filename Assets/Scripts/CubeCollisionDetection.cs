using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollisionDetection : MonoBehaviour
{
    public bool isCollideWithCube = false;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube") && !isCollideWithCube)
        {
            isCollideWithCube = true;
            audioSource.Play();
            Debug.Log("Cube: " + isCollideWithCube);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        isCollideWithCube = false;
    }
}
