using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{   
    public Transform posA,posB;
    public int speed;
    Vector3 targetPos;
    void Start() {
       targetPos = posB.position;
    }
    void Update() {
        if(Vector3.Distance(transform.position,posA.position) < 1f ) {
            targetPos = posB.position;
        }
        if(Vector3.Distance(transform.position,posB.position) < 1f ) {
            targetPos = posA.position;
        }
        transform.position = Vector3.MoveTowards(transform.position,targetPos, speed * Time.deltaTime);
    }
}
