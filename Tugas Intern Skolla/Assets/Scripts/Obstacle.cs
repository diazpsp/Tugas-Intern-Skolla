using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private GameObject player;
    // Start is called before the first frame update
   void OnCollisionEnter(Collision coll){
    if(coll.gameObject.tag == "Player"){
        Destroy(player);
    }
   }
}
