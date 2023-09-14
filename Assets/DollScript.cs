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
        //if (collision.gameObject.CompareTag("Coeur"))
        //{
        //    doorAnimatorController.SetBool("ouverture", true);

        //    // Load the music file
        //    music = Resources.Load<AudioClip>("Assets/Horror Elements/Ambient/Amb_scary.wav");

        //    // Play the music
        //    AudioSource audioSource = GetComponent<AudioSource>();
        //    audioSource.PlayOneShot(music);

        //    // Stop the scene-of-murder audio clip
        //    AudioSource sceneOfMurderAudioSource = GetComponentInChildren(gameObject, "sceneOfMurderAudioSource");
        //    if (sceneOfMurderAudioSource != null && sceneOfMurderAudioSource.CompareTag("sceneOfMurderAudioSource"))
        //    {
        //        sceneOfMurderAudioSource.Stop();
        //    }
        //}
    }
}