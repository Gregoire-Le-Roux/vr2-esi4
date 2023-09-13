using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject Door;
    public PyramidCollisionDetection pyramidCollision;
    public SpheresCollisionDetection sphereCollision;
    public CubeCollisionDetection cubeCollision;

    private Animator anim;
    private bool hasOpened = false;
    private AudioSource audioSource;

    private void Start()
    {
        anim = Door.GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (!hasOpened && 
            pyramidCollision.isCollideWithPyramid &&
            sphereCollision.isCollideWithSphere &&
            cubeCollision.isCollideWithCube) 
        {
            // Door.SetActive(false);

            anim.SetBool("isOpen", true);
            audioSource.Play();
            hasOpened = true; // La porte est ouverte, ne répète pas l'animation.
        }
    }
}
