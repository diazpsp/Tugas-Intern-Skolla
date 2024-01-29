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
           mVCManager.AddBounce(1);
        }  
    }

    void OnCollisionExit(Collision coll){
        if(coll.gameObject.tag == "Ground"){isGrounded=false;}
    }

    public void OnTriggerEnter(Collider coll){
        if(coll.gameObject.tag == "Coin"){
            // mVCManager.coinController.OnTriggerCoin();
            DependencyInjector.Instance.GetController<CoinController>().GetScoreCoin();
        }
    }
}
