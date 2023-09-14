using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCollisionDetection : MonoBehaviour
{
    public GameObject Door;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coeur"))
        {
          Door.SetActive(false);
        }
    }
}