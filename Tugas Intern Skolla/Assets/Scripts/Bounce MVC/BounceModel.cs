using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BounceModel : MonoBehaviour
{
    // public Collider playerColl;
    public string stringTextTitle;
    public Text textView;
    public float bounces;
    
    // Start is called before the first frame update
     public void AddBounce(float bounce)
    {
       bounces+=bounce;
    }
}
