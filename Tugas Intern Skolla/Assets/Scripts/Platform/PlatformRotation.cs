using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRotation : MonoBehaviour
{
    

    [SerializeField] private float speed,z,x,y,setTime;
    private float time;
   
    void Start()
    {
        time = setTime;
     
    }

    // Update is called once per frame
    void Update()
    {   
            Debug.Log(transform.localEulerAngles.z);
        time -= Time.deltaTime;
        if (time>= 0)
        {
            transform.Rotate(x* Time.deltaTime * speed, y * Time.deltaTime * speed, z * Time.deltaTime * speed);
        }
        
            
        else if(time < 0 && time >= -setTime - 2){
            transform.Rotate(-x* Time.deltaTime * speed, -y * Time.deltaTime * speed, -z * Time.deltaTime * speed);
        }else{
            time = setTime + 1.8f;
        }
           
            
    }
   
}
