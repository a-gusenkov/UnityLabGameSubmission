using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullFollow : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;

    public Transform player;
    
    private Vector2 target;
    

    void Start(){
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
    }

    void Update(){
        if(Vector2.Distance(transform.position, player.position) > stoppingDistance){
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        } else if(Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance){
            transform.position = this.transform.position;
        } else if (Vector2.Distance(transform.position, player.position) < retreatDistance){
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }
    }
}
