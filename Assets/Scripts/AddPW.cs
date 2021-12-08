using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AddPW : MonoBehaviour
{
    public static AddPW instance ;
    [SerializeField] Text witchPointText;
    public int wHits;
    
    
    
    void Awake(){
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        witchPointText = GetComponent<Text>();
        witchPointText.text = "Witch Hits :" + PlayerPrefs.GetInt("wHits",wHits).ToString();
       

    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void DisplayScore()
    {
        witchPointText.text =  "Witch Hits :" + PlayerPrefs.GetInt("wHits",wHits).ToString();
    }
    //in the future we can try making a hidden counter
    //for total points via leaf varibale
    public void AddPoints(){
        
        wHits =  PlayerPrefs.GetInt("wHits",wHits) + 1;
        PlayerPrefs.SetInt("wHits",wHits);
        DisplayScore();
        
       
    }
}
