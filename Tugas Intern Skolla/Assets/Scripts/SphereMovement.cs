using UnityEngine.UI;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
// using UnityEngine.EventSystems;

public class SphereMovement : SphereMoveData
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        MovementInput();
        // Debug.Log(bounceCount);
        if(isGrounded ==true){
            Jump();
      
        } 
       
    }
    void FixedUpdate(){
        MoveBall();
    }
     void OnCollisionEnter(Collision coll){
        if(coll.gameObject.tag == "Ground"){
           isGrounded = true;
           Debug.Log("collis");
           
        }
          
    }
    void OnCollisionExit(Collision coll){
        if(coll.gameObject.tag == "Ground"){isGrounded=false;}
    }
}
