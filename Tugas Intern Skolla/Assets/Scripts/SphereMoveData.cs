using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMoveData : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public float speed ,jump,bounceCount,horizontal,vertical;
    public Rigidbody rb;
    public BounceController balCon;
    public bool isGrounded = true;
    public MVCManager mVCManager;
    
    [SerializeField]
    private Transform cam;
    private Vector3 forwardRelative,rightRelative,moveDir;
   
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
