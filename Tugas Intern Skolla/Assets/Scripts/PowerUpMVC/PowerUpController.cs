using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : Controller
{
    public PowerUpModel model;
    public PowerUpView view;
    // Start is called before the first frame update
    public void GetPowerUp()
    {   

        model.isPowerOn = true;
        model.time = 4f;
        
    }
    
    public override Type GetControllerType(){
        return typeof(PowerUpController);
    }
    void Update(){
        if(model.isPowerOn){
            model.time -= Time.deltaTime;
            view.DisplayPowerUp(true);
        }
        
        if (model.time < 0)
        {
            model.time= 0;
            view.DisplayPowerUp(false);
            model.isPowerOn = false;
        }
    }
    
}
