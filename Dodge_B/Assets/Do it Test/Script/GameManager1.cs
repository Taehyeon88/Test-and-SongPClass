using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager1 : MonoBehaviour
{
    public GameObject gameoverText;
    public Text timeText;
    public Text recordText;

    private float surviveTime;
    private bool isGameOver;

    void Start()
    {
        surviveTime = 0;
        isGameOver = false;
    }

    void Update()
    {
        if(!isGameOver)
        {
            
            surviveTime += Time.deltaTime;
           
            timeText.text = "Time : " + (int)surviveTime;
        }
        else
        {

            gameoverText.SetActive(true);

            if( Input.GetKeyDown(KeyCode.R) )
            {
                SceneManager.LoadScene(0);
            }
        }

    }


    public void EndGame()
    {

        isGameOver = true;

        gameoverText.SetActive(true);

        float bestTime = PlayerPrefs.GetFloat("BestTime");

        if(surviveTime > bestTime) 
        {
         bestTime = surviveTime;

         PlayerPrefs.SetFloat("BestTime", bestTime);

        }

        recordText.text = "BestTime : " + (int)bestTime;
    }
}
