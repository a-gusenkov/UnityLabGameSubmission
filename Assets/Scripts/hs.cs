using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hs : MonoBehaviour
{
    public static hs instance ;
    [SerializeField] Text hs1PointText;
    [SerializeField] Text hs2PointText;
    [SerializeField] Text hs3PointText;
    [SerializeField] Text hs4PointText;
    [SerializeField] Text hs5PointText;
    public int hs1;
    public int hs2;
    public int hs3;
    public int hs4;
    public int hs5;
    public int compa;
    // Start is called before the first frame update
    void Start(){
        
        
        int compa = PlayerPrefs.GetInt("wHits");
        if(compa >= PlayerPrefs.GetInt("hs5")){
            PlayerPrefs.SetInt("hs5",compa);
            
        }else if(PlayerPrefs.GetInt("hs4") <= PlayerPrefs.GetInt("hs5") && PlayerPrefs.GetInt("hs4") >= PlayerPrefs.GetInt("hs3")){
            PlayerPrefs.SetInt("hs4",compa);
            
        }else if(PlayerPrefs.GetInt("hs3") <= PlayerPrefs.GetInt("hs4") && PlayerPrefs.GetInt("hs3") >= PlayerPrefs.GetInt("hs2")){
            PlayerPrefs.SetInt("hs3",compa);
            
        } else if(PlayerPrefs.GetInt("hs2") <= PlayerPrefs.GetInt("hs3") && PlayerPrefs.GetInt("hs2") >= PlayerPrefs.GetInt("hs1")){
            PlayerPrefs.SetInt("hs2",compa);
            
        }else if (PlayerPrefs.GetInt("hs1") <= PlayerPrefs.GetInt("hs2") ){
            PlayerPrefs.SetInt("hs1",compa);
            
        }

        
        hs1PointText.text = "HighScore 1 :" + PlayerPrefs.GetInt("hs1",hs2).ToString();
        hs2PointText.text = "HighScore 2 :" + PlayerPrefs.GetInt("hs2",hs2).ToString();
        hs3PointText.text = "HighScore 3 :" + PlayerPrefs.GetInt("hs3",hs3).ToString();
        hs4PointText.text = "HighScore 4 :" + PlayerPrefs.GetInt("hs4",hs4).ToString();
        hs5PointText.text = "HighScore 5 :" + PlayerPrefs.GetInt("hs5",hs5).ToString();
    
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DisplayHS()
    {
        
        
        hs1PointText.text = "HighScore 1 :" + PlayerPrefs.GetInt("hs1").ToString();
        hs2PointText.text = "HighScore 2 :" + PlayerPrefs.GetInt("hs2").ToString();
        hs3PointText.text = "HighScore 3 :" + PlayerPrefs.GetInt("hs3").ToString();
        hs4PointText.text = "HighScore 4 :" + PlayerPrefs.GetInt("hs4").ToString();
        hs5PointText.text = "HighScore 5 :" + PlayerPrefs.GetInt("hs5").ToString();
    
    }

}
  
