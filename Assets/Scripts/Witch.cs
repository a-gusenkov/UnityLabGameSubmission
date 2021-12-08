using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;
public class Witch : MonoBehaviour
{

    public GameObject wh3;
    public GameObject wh2;
    public GameObject wh1;
    public int health = 3;
  
   

    public void TakeDamageW (int damage){
        health = health - damage;

        if (health == 2){
            Destroy(wh1.gameObject);
        }
        else if(health == 1){
            Destroy(wh2.gameObject);
        }

        if(health == 0){
            Destroy(wh3.gameObject);
            DieW();
        }
    }
    void DieW(){
        
        Destroy(gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
