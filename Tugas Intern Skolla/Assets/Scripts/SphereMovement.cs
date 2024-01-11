using UnityEngine.UI;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
// using UnityEngine.EventSystems;

public class SphereMovement : BounceElement
{
    
    [SerializeField] private float speed ,jump,bounceCount,horizontal,vertical;
   
    [SerializeField] Transform cam;
    [SerializeField] private Vector3 forwardRelative,rightRelative,moveDir;
    public Rigidbody rb;
    public bool isGrounded = true;
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
           bounceCount++;
           app.controller.OnBallGroundHit();
        }

        // if(coll.gameObject.TryGetComponent<Kuotak>(out Kuotak kotak))
        // {
        //     Debug.Log("YEs");
        //     Debug.Log(kotak.Peot);
        //     kotak.Peot = "e";
        //     Debug.Log(kotak.Peot);
        // }
        //to display how many ball bounced
         
    }
    void OnCollisionExit(Collision coll){
        if(coll.gameObject.tag == "Ground"){isGrounded=false;}
    }
    

    public void Jump(){
        if(Input.GetButtonDown("Jump")){ //getkeydown keycode.space?
        Debug.Log("Jump");
        rb.velocity = new Vector3(rb.velocity.x,jump,rb.velocity.z);
        
        }
    }
    public void MovementInput(){
        horizontal = Input.GetAxis("Horizontal")*speed;
        vertical = Input.GetAxis("Vertical")*speed;
        
        Vector3 camForward = cam.forward;
        Vector3 camRight = cam.right;

        camForward.y = 0;
        camRight.y = 0;
        
        // creating related cam direction
        forwardRelative = vertical* camForward;
        rightRelative = horizontal * camRight;
        moveDir = forwardRelative + rightRelative;

        //
    }
    public void MoveBall(){
        
        rb.velocity= new Vector3(moveDir.x,rb.velocity.y,moveDir.z);
       
    }
}
