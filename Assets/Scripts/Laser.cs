using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastDetect : MonoBehaviour
{
    public LayerMask layerMask;
    
    public GameObject Laser;
    public Animator Door;
    public bool DoorIsClosed = false;

    void Update()
    {
        if (!DoorIsClosed){
            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                Door.SetBool("doorIsOpen",true);
                DoorIsClosed = true;
                Laser.SetActive(false);
            }
            else
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            }
        }
    }   
}