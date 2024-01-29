using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class BounceElement : MonoBehaviour{
    //// Gives access to the application and all instances.
    public BounceApplication app { get { return GameObject.FindObjectOfType<BounceApplication>(); }}

}
    public class BounceApplication : BounceElement
{
   
      // Reference to the root instances of the MVC.
    public BounceModel model;
    public BounceView view;
    public BounceController controller;
    // Start is called before the first frame update
    
}
