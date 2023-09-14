using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoeurScript : MonoBehaviour
{
    // Variable publique pour stocker la r�f�rence de l'objet poup�e
    public GameObject doll;

    // �v�nement OnTriggerEnter
    private void OnTriggerEnter(Collider other)
    {
        // V�rifiez si l'objet qui touche est doll
        if (other.gameObject.tag == "doll")
        {
            // alors d�truire coeur
            Destroy(doll);
        }
    }
}