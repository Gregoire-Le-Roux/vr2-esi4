using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoeurScript : MonoBehaviour
{
    // Variable publique pour stocker la référence de l'objet poupée
    public GameObject doll;

    // Événement OnTriggerEnter
    private void OnTriggerEnter(Collider other)
    {
        // Vérifiez si l'objet qui touche est doll
        if (other.gameObject.tag == "doll")
        {
            // alors détruire coeur
            Destroy(doll);
        }
    }
}