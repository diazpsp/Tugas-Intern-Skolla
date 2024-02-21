using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverText,gameCompleteText;
   
    
    [SerializeField] private FinishCondition finishCon;
    [SerializeField] private TimeExtenderModel timeExModel;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if(DependencyInjector.Instance.GetController<PlayerController>().view == null){
            gameOverText.SetActive(true);
            StartCoroutine(PauseTime());
        }
        if(finishCon.isCompleted){
            gameCompleteText.SetActive(true);
            StartCoroutine(PauseTime()); 
        }
        if(timeExModel.timer <=0){
            finishCon.gameObject.SetActive(false);
            gameOverText.SetActive(true);
            StartCoroutine(PauseTime());
        }
    }
    IEnumerator PauseTime(){
        yield return new WaitForSeconds(1f);
        Time.timeScale = 0 ;
    }
}
