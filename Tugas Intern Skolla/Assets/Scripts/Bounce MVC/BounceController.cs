using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceController : Controller
{
    public BounceModel bounceModel;
    public BounceView bounceView;

    public override Type GetControllerType()
    {
       return typeof(BounceController);
    }

 
    public void OnBallGroundHit(){
     
       bounceModel.AddBounce(1);
        bounceView.GetBounce();
    }
}
