using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// public class IMVCManager : MonoBehaviour
// {
//     public string a;
//     public float ea;
//     public  IMVCManager(string name, int numbah){
    
// }

// }
public interface IMVCManager{

    void AddScore(float score);
    void AddBounce(float bounce);
    string GetScore();
    string GetBounce();
}



