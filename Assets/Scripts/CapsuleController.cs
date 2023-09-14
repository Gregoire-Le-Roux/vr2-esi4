using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleController : MonoBehaviour
{
    public GameObject Player;

    private Vector3 capsulePosition;
    private Quaternion capsuleRotation;
    // Start is called before the first frame update
    void Update()
    {
        Vector3 playerPosition = Player.transform.position;
        Quaternion playerRotation = Player.transform.rotation;

        capsulePosition = playerPosition;
        capsuleRotation = playerRotation;

        transform.position = capsulePosition;
        transform.rotation = capsuleRotation;        
    }
}
