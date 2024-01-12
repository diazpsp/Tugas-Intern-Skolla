using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceController : BounceElement
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //handles the ball hit event
    public void OnBallGroundHit(){
        app.model.bounces++;
        app.model.stringTextTitle = "Bounces: "+app.model.bounces.ToString();
        
        if(app.model.bounces >= app.model.winCondition){
            app.model.ball.enabled = false;
            app.model.ball.GetComponent<Rigidbody>().isKinematic=true;
            OnGameComplete();
        }
    }

    public void OnGameComplete(){
        Debug.Log("Victory");
    }
}
