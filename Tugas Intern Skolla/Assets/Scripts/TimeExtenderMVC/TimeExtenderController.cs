using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeExtenderController : Controller
{
    public TimeExtenderModel model;
    public TimeExtenderView view;
    // Start is called before the first frame update
    public void AddTimer()
    {         
        model.timer += 5f;
        
    }
    
    public override Type GetControllerType(){
        return typeof(TimeExtenderController);
    }
    // Update is called once per frame
    void Update()
    {
        if(model.timer>0){
            view.DisplayTimer();
            model.timer-=Time.deltaTime;
        }
        if(model.timer<0){
            view.DisplayTimer();
            model.timer = 0;
        }
    }
}
