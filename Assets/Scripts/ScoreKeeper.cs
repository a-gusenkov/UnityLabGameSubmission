using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] int score;
    const int DEFAULT_POINTS = 1;
    //const int SCORE_THRESHOLD = 5;
    
    int score_threshold;
    [SerializeField] Text scoreTxt;
    [SerializeField] Text sceneTxt;
    [SerializeField] Text nameTxt;
    
    [SerializeField] string playerName;

    // Start is called before the first frame update
    void Start()
    {
        
       // playerName = PerData.Instance.GetName();
       // score = PerData.Instance.GetScore();

        
        DisplayName();
   
        DisplayScore();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddPoints(int points)
    {
        score += points;
        Debug.Log("score " + score);
        DisplayScore();
        PerData.Instance.SetScore(score);

        

    }


    public void AddPoints()
    {
        AddPoints(DEFAULT_POINTS);
    }

    public void DisplayScore()
    {
        scoreTxt.text = "Score: " + score;
    }
    public void DisplayName()
    {
        nameTxt.text = playerName;
    }

    

  

   
}
