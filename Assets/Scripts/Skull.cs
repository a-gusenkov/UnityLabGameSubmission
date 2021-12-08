using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Skull : MonoBehaviour
{
    public GameObject sh3;
    public GameObject sh2;
    public GameObject sh1;
    public int health = 3;

    public float speed;
   

    public float timeBtwShots;
    public float startTimeBtwShots;

    public GameObject projectile;
   
    Vector2 goToY;
    float originalY;

    public float floatLength;


    void Start(){
        

        timeBtwShots = startTimeBtwShots;
        this.originalY = this.transform.position.y;
    }

    void Update(){
        goToY = transform.position;
        goToY.y = (Mathf.Sin(Time.time) * floatLength);
        transform.position = goToY;

        if (timeBtwShots <= 0){
            Instantiate(projectile, transform.position, Quaternion.identity);
            timeBtwShots = startTimeBtwShots;

        } else{
            timeBtwShots -= Time.deltaTime;
        }
    }
    

    public void TakeDamage (int damage){
        health = health - damage;

        if (health == 2){
            Destroy(sh1.gameObject);
        }
        else if(health == 1){
            Destroy(sh2.gameObject);
        }

        if(health == 0){
            Destroy(sh3.gameObject);
            Die();
        }
    }
    void Die(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Destroy(gameObject);
    }

  
}
