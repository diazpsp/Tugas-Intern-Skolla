using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Transform> children;
    void Start(){
       children = GetChildren(transform);
    }
    void Update(){
        
    }
    List<Transform> GetChildren(Transform parent){
        List<Transform> children = new List<Transform>();
        foreach(Transform child in parent)
        {
            children.Add(child);
        }
        return children;
    }

}

