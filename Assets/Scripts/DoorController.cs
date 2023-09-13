using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject Door;
    public PyramidCollisionDetection pyramidCollision;
    public SphereCollisionDetection sphereCollision;
    public CubeCollisionDetection cubeCollision;

    private void Update()
    {
        if (pyramidCollision.isCollideWithPyramid &&
            sphereCollision.isCollideWithSphere &&
            cubeCollision.isCollideWithCube)
        {
            Door.SetActive(false);
        }
    }
}
