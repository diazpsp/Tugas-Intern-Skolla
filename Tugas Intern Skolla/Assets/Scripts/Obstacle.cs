using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private PowerUpContainer powerUpContainer;

    // Start is called before the first frame update
    void Start(){
        player = GameObject.Find("Player");
        powerUpContainer = GameObject.FindObjectOfType<PowerUpContainer>();
    }
   void OnCollisionEnter(Collision coll){
   

        if(coll.gameObject.tag == "Player"){ 
            if(powerUpContainer.isPowerOn){
                Destroy(gameObject);
            }else
            {
                Destroy(player);
            }
    }
}
}
