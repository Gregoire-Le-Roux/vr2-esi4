using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastDetect : MonoBehaviour
{
    public LayerMask layerMask;
    public GameObject Door;
    public GameObject Laser;

    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Door.SetActive(false);
            Laser.SetActive(false);
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
        }
    }
}