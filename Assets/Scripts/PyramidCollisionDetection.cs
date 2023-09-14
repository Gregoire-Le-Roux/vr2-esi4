using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyramidCollisionDetection : MonoBehaviour
{
    public bool isCollideWithPyramid = false;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pyramide") && !isCollideWithPyramid)
        {
            isCollideWithPyramid = true;
            Debug.Log("Pyramide: " + isCollideWithPyramid);
            audioSource.Play();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        isCollideWithPyramid = false;
    }
}
