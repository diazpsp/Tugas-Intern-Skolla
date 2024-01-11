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
        app.model.textView.text = app.model.bounces.ToString();
        if(app.model.bounces >= app.model.winCondition){
            app.view.ball.enabled = false;
            app.view.ball.GetComponent<Rigidbody>().isKinematic=true;
            OnGameComplete();
        }
    }

    public void OnGameComplete(){
        Debug.Log("Victory");
    }
}
