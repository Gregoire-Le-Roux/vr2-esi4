using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpheresCollisionDetection : MonoBehaviour
{
    public bool isCollideWithSphere = false;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sphere") && !isCollideWithSphere)
        {
            isCollideWithSphere = true;
            audioSource.Play();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        isCollideWithSphere = false;
    }
}
