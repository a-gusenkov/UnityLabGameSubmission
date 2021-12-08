using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;


    private Transform player;
    
    private Vector2 target;
    public int damage = 1;
    public AudioSource bulletSound;

    void Start(){
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);

        
            bulletSound = GetComponent<AudioSource>();
        
    }

    void Update(){
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if(transform.position.x == target.x && transform.position.y == target.y){
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D hitInfo){
        bulletSound.Play();
        //AudioSource.PlayClipAtPoint(GetComponent<AudioSource>().clip, transform.position);
        Witch witchs = hitInfo.GetComponent<Witch>();
       
        if(witchs != null){
            
            
            witchs.TakeDamageW(damage);
            AddPW.instance.AddPoints();
             
            Destroy(gameObject);
        }
        
    } 

  
    
}
