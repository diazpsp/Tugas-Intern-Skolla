using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestroyObjects : MonoBehaviour
{
   
   void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Player")
        {
           
            Destroy(col.gameObject);
        }
    }
}
