using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceView : BounceElement
{
    public BounceModel bounceModel;
    // Start is called before the first frame update
    public string GetBounce()
    {
        return bounceModel.textView.text = "Bounce: " + bounceModel.bounces.ToString();
    }
  
}
