using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishCondition : MonoBehaviour
{
    public GameObject gameOverImage;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(){
        gameOverImage.SetActive(true);
        StartCoroutine(PauseTime());
    }
    IEnumerator PauseTime(){
        yield return new WaitForSeconds(1f);
        Time.timeScale = 0 ;
    }
}
