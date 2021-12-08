using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySH3 : MonoBehaviour
{
    public int health = 3;
    

    public void TakeDamages (int damage){
        health = health - damage;

        

        if(health == 0){
            
            Delete();
        }
    }
    void Delete(){
        
        Destroy(gameObject);
    }
}
