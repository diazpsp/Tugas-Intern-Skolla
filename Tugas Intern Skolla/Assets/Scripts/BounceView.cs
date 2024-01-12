using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceView : BounceElement
{
    
    // Start is called before the first frame update
    void Update(){

        DisplayBounce();
    }
    void DisplayBounce(){
        app.model.textView.text = app.model.stringTextTitle;
    }
}
