using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class witchController : MonoBehaviour
{
    //speed and movement
    public float speed = 5f;
    Vector2 movement;
   
    //Checks if king is on ground
    private Rigidbody2D witchBody;

    //King is only effected by collisions in the groundLayer
    //private Animator witchAnimation;
    // Start is called before the first frame update

    void Start()
    {
        witchBody = GetComponent<Rigidbody2D> ();
        //witchAnimation = GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

       // witchAnimation.SetFloat("Horizontal", movement.x);
       // witchAnimation.SetFloat("Vertical", movement.y);
       // witchAnimation.SetFloat("Speed", movement.sqrMagnitude);
       
        
    }

    void FixedUpdate(){
        witchBody.MovePosition(witchBody.position + movement * speed * Time.fixedDeltaTime);
    }
}
