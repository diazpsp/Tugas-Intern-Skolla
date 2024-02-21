using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestroy : MonoBehaviour
{
    // Start is called before the first frame update
   void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Player")
        {
           
            Destroy(gameObject);
        }
    }
}
