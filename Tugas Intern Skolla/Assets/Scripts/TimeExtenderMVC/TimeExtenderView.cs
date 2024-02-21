using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeExtenderView : MonoBehaviour
{
    public TimeExtenderModel model;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   public void DisplayTimer()
    {
        
            model.timerText.text = model.timer.ToString("Timer: "+(int)model.timer);
       
    }
}
