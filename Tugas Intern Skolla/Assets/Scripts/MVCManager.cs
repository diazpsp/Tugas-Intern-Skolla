// using System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Security.Cryptography;
using UnityEngine;

public class MVCManager : MonoBehaviour,IMVCManager
{
    [Header("MVC")]
    
    public CoinModel coinModel;
    public CoinController coinController;
    public CoinView coinView;
    public BounceView bounceView;
    public BounceController bounceController;
    public BounceModel bounceModel;
   
    private MVCManager mVCManager;
    

    protected virtual void Start(){
        mVCManager = FindObjectOfType<MVCManager>();
    }
    void Update(){
      
        
        
    }

    // Update is called once per frame
    public string GetBounce()
    {
        return bounceModel.textView.text = "Bounce: " + bounceModel.bounces.ToString();
    }
   
    public void AddScore(float score)
    {
        coinModel.coinCount+=score;
    }

    public void AddBounce(float bounce)
    {
       bounceModel.bounces+=bounce;
    }

    public string GetScore()
    {
        
         return coinModel.coinText.text = "Coin: "+coinModel.coinCount.ToString();
    }
}

