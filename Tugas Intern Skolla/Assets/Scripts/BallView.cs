
using UnityEngine;


public class BallView : BounceElement
{

   


    // Start is called before the first frame update
    void Start(){
        // app.model.playerColl = GetComponent<Collider>();
    }
        
    
    void OnCollisionEnter(Collision coll){
        if(coll.gameObject.tag == "Ground"){
            // app.controller.OnBallGroundHit();
            // Debug.Log("SU");
        }
    }
}