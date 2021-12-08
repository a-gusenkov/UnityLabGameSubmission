using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AddPS : MonoBehaviour
{
   public static AddPS instance;
    [SerializeField] Text skullPointText;
    
    
    
    public int sHits;
    
    
    
    void Awake(){
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        skullPointText = GetComponent<Text>();
        skullPointText.text = "Skull Hits :" + PlayerPrefs.GetInt("sHits",sHits).ToString();
       

    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void DisplayScore()
    {
        skullPointText.text =  "Skull Hits :" + PlayerPrefs.GetInt("sHits",sHits).ToString();
    }
    //in the future we can try making a hidden counter
    //for total points via leaf varibale
    public void AddPoints(){
        
        sHits =  PlayerPrefs.GetInt("sHits",sHits) + 1;
        PlayerPrefs.SetInt("sHits",sHits);
        DisplayScore();
       
    }

    

 }
