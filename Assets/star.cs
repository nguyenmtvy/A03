using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star : MonoBehaviour
{
    public float speed;
    public float jump;
    float movementSpeed;
    bool onGround = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (onGround){
            GetComponent<Rigidbody2D>().velocity = new Vector2(
                GetComponent<Rigidbody2D>().velocity.x, jump);
            }
        }
        movementSpeed = 0;
        if (Input.GetKeyDown(KeyCode.A)){
            movementSpeed = -speed;
            GetComponent<Rigidbody2D>().velocity = new Vector2(movementSpeed, 
                                                GetComponent<Rigidbody2D>().velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.D)){
            movementSpeed = speed;
            GetComponent<Rigidbody2D>().velocity = new Vector2(movementSpeed, 
                                                GetComponent<Rigidbody2D>().velocity.y);
        }
        
    }
    void OnTriggerEnter2D(){
        onGround = true;
    }
    void OnTriggerExit2D(){
        onGround = false;
    }
    /*void OnCollisionEnter2D(){
        if (col.gameObject.tag.Equals("Enemy")){
            gameOverText.SetActive(true);
        }
    }*/
}
