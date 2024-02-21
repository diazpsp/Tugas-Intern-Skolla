using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoinController: Controller
{
    public CoinModel coinModel;
    public CoinView coinView;
   
     public void GetScoreCoin()
    {   

        coinModel.AddScoreCoin(1);
        coinView.DisplayCoin(coinModel);
    }
    
    public override Type GetControllerType(){
        return typeof(CoinController);
    }

    public void BounceCount(){
        BounceController bounceController = GetController<BounceController>();
    }

    
}
