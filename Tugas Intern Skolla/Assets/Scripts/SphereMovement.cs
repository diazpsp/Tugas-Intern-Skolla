using UnityEngine.UI;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using System.Linq.Expressions;
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
           DependencyInjector.Instance.GetController<BounceController>().OnBallGroundHit();
        }  
    }

    void OnCollisionExit(Collision coll){
        if(coll.gameObject.tag == "Ground"){isGrounded=false;}
    }

    public void OnTriggerEnter(Collider coll){
        if(coll.gameObject.tag == "Coin"){
           
            DependencyInjector.Instance.GetController<CoinController>().GetScoreCoin();
        }
        if(coll.gameObject.tag == "Power Up"){
            
        }
    }
}
