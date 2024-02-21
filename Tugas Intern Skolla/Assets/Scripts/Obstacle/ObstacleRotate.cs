using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRotate : MonoBehaviour
{
    [SerializeField]private float zSpeed,ySpeed,xSpeed;
  
    void Update()
    {
        transform.Rotate(xSpeed,ySpeed,zSpeed);
    }
}
