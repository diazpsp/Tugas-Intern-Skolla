using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public float speed = 8,jump = 7,bounceCount,horizontal,vertical,player,time;
    public Rigidbody rb;
    public bool isGrounded = true;
 
    [SerializeField]
    private Transform cam;
    private Vector3 forwardRelative,rightRelative,moveDir;
    public PlayerModel model;
    
    
    void Start(){
        cam = GameObject.Find("Main Camera").GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
        model = GameObject.Find("Player Model").GetComponent<PlayerModel>();
        time = 1f;
    }
    void Update(){
        time -= Time.deltaTime;
    }

    public void Jump(){
        if(Input.GetButtonDown("Jump")){ 
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
    void OnCollisionEnter(Collision coll){
        if(coll.gameObject.tag == "Ground"){
          isGrounded = true;
           Debug.Log("collis");
           DependencyInjector.Instance.GetController<BounceController>().OnBallGroundHit();
        }  
        if(coll.gameObject.tag == "Destroyable Obs"){
            if(DependencyInjector.Instance.GetController<PowerUpController>().model.isPowerOn){
                Destroy(coll.gameObject);
            }else
            {
                Destroy(gameObject);   
            }
        }
    }
    void OnCollisionExit(Collision coll){
        if(coll.gameObject.tag == "Ground"){isGrounded=false;}
    }
    public void OnTriggerEnter(Collider coll){
        if(coll.gameObject.tag == "Coin"){
            Destroy(coll.gameObject);
            DependencyInjector.Instance.GetController<CoinController>().GetScoreCoin();
        }
        if(coll.gameObject.tag == "Power Up"){
            DependencyInjector.Instance.GetController<PowerUpController>().GetPowerUp();
            Destroy(coll.gameObject);
        }
        if(coll.gameObject.tag == "Time Extender"){
            DependencyInjector.Instance.GetController<TimeExtenderController>().AddTimer();
            Destroy(coll.gameObject);
        }
        
        #region touching another player
        if(coll.gameObject.tag == "Player"){
            TransferBall(coll);
            Debug.Log("Touched");
        }
       
        #endregion
       
    }
    public void Swap(){
        model.character = model.players[model.whichCharacter];
        model.character.AddComponent<PlayerView>();
        for(int i = 0; i < model.players.Count; i++)
        {
            if(model.players[i] != model.character)
            {
                Destroy(model.players[i].GetComponent<PlayerView>());
                model.cameras[i].SetActive(false);
            }else
            {
                cam = model.cameras[i].GetComponent<Transform>();
                model.cameras[i].SetActive(true);
                
            }
        }
    }
    void TransferBall(Collider coll){
        
        if(time>0){
            gameObject.GetComponent<SphereCollider>().enabled = false;
            
        }else{
            gameObject.GetComponent<SphereCollider>().enabled = true;
            if(coll.gameObject.name == "Player 1" && model.whichCharacter != 0){
                if(model.whichCharacter == 2){
                    model.whichCharacter = 0;
                }
                if(model.whichCharacter == 1){
                    model.whichCharacter -= 1;
                }
                Swap();
                Debug.Log("To 1");
            
            }
            if(coll.gameObject.name == "Player 2" && model.whichCharacter != 1){
                if(model.whichCharacter == 0 ){
                    model.whichCharacter = model.players.Count - 2;
                }
                if(model.whichCharacter == 2){
                    model.whichCharacter -= 1;
                }
                Swap();
                Debug.Log("To 2");
            }
            if(coll.gameObject.name == "Player 3" && model.whichCharacter != 2){
                if(model.whichCharacter == 1 ){
                    model.whichCharacter = model.players.Count-1;
                }
                if(model.whichCharacter == 0){
                    model.whichCharacter += 2;
                }
                Swap();
            }
        }
    }
}
