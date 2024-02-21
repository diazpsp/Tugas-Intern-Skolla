using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float speed,distance;
    [SerializeField] GameObject platform;
    [SerializeField] bool isDetected;
    private Vector3 startPos;
    void Start()
    {
        startPos = platform.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(isDetected)	{
            if (platform.transform.position.x < startPos.x + distance)
            {
                platform.transform.position += Vector3.right * Time.deltaTime * speed;
            }
            else{

            }
        }
    }
    void OnTriggerEnter(){
        isDetected = true;
            
    }
}
