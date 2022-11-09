using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   //Declare Rigidbody in a variable
    private Rigidbody playerRb;
    //Physics based Variables
    public float jumpForce = 10;
    public float gravityModifier;
    //Double Jump Variable
    public bool isOnGround = false;
    //gameover variable
    public bool gameOver = false;
    //Variable for animation
    private Animator playerAnim;
    // Start is called before the first frame update
    void Start()
    {
        //Get the variable = to Ridgidbody
        playerRb = GetComponent<Rigidbody>();
        //Add Physics to the game
        Physics.gravity *= gravityModifier;
        //Uses the variable to call the animator component into the script
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Space bar makes the player jump but must be on ground to jump.
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver) 
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
        }
    }

    //Method to make the IsonGround true after the player collides with the ground
    private void OnCollisionEnter(Collision collision)
    {
        //When you collide with the ground, it makes the variable true
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }

        //Makes it so that when you hit an obstacle, the game is over
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over");
            gameOver = true;
            //Death animation
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
        }

    }
}
