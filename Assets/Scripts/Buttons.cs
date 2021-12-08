using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void nextScene(){
        SceneManager.LoadScene("GameLv1");
    }
    public void loadHome(){
         PlayerPrefs.DeleteKey("sHits");
         PlayerPrefs.DeleteKey("wHits");
        SceneManager.LoadScene("Home");
    }
    public void loadLevel1(){
        SceneManager.LoadScene("GameLv1");
    }
    public void loadEnd(){
        SceneManager.LoadScene("EndScreen");
    }
    public void loadInstruct(){
        SceneManager.LoadScene("Instructions");

    }
    public void loadSetting(){
        SceneManager.LoadScene("Settings");
    }
    public void loadHS(){
        SceneManager.LoadScene("HighScore");
    }
    public void loadName(){
        SceneManager.LoadScene("EnterName");
    }
}
