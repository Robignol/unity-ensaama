using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{       
    public float speed = 5f;
    public float jumpSpeed = 3f;
    public float jumpCoolDown = 0f;

    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
      Rigidbody body = GetComponent<Rigidbody>();

      Vector3 move = new Vector3();

      move.x = speed * Input.GetAxis("Horizontal");
      move.z = speed * Input.GetAxis("Vertical");
      move.y = body.velocity.y;


      //sauter//
                if (Input.GetKeyDown(KeyCode.Space)){
                move.y = jumpSpeed;
                

                //cooldown de saut//
                jumpCoolDown = jumpCoolDown - Time.deltaTime;
                if (Input.GetKeyDown(KeyCode.Space) && jumpCoolDown <= 0){
                    jumpCoolDown = 1.5f;
                    move.y = jumpSpeed;
                
                }
                }

      body.velocity = move;




          
    

    }

}