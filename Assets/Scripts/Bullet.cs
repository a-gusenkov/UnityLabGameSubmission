using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 1;
    public Rigidbody2D rb;
    //public AudioSource bulletSound;
    private ScoreKeeper scoreKeeper;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        /*
        if (bulletSound == null){
            bulletSound = GetComponent<AudioSource>();
        }
        */
        
    }



    void OnTriggerEnter2D (Collider2D hitInfo){
        //AudioSource.PlayClipAtPoint(GetComponent<AudioSource>().clip, transform.position);
        Skull skulls = hitInfo.GetComponent<Skull>();
       
        
        if(skulls != null){
            //scoreKeeper.AddPoints(1);
            skulls.TakeDamage(damage);
            AddPS.instance.AddPoints(); 
            Destroy(gameObject);
        }
        
       
        

    }

}
