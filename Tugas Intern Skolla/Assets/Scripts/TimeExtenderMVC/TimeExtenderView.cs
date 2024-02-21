using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeExtenderView : MonoBehaviour
{
    public TimeExtenderModel model;

   public void DisplayTimer()
    {
        
            model.timerText.text = model.timer.ToString("Timer: "+(int)model.timer);
       
    }
}
