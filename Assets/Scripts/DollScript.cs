using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollScript : MonoBehaviour
{
    public GameObject Door;
    public Animator doorAnimatorController;

    public AudioSource doorSound;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coeur"))
        {
            doorAnimatorController.SetBool("doorIsOpen", true);
            doorSound.Play();
        }
    }
}