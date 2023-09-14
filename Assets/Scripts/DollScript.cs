using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollScript : MonoBehaviour
{
    public GameObject Door;
    public Animator doorAnimatorController;

    private AudioClip music;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coeur"))
        {
            doorAnimatorController.SetBool("doorIsOpen", true);
        }
    }
}