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

    // Start is called before the first frame update

    // handles the ball hit event
    public void OnBallGroundHit(){
     
       bounceModel.AddBounce(1);
        bounceView.GetBounce();
    }
//    public T GetView<T>() {
        
//         return DependencyInjector.Instance.GetView<T>();

//     }

}
