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
    // Start is called before the first frame update
    void Start()
    {
        //Get the variable = to Ridgidbody
        playerRb = GetComponent<Rigidbody>();
        //Add Physics to the game
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        //Space bar makes the player jump but must be on ground to jump.
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    //Method to make the IsonGround true after the player collides with the ground
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over");
            gameOver = true;
        }

    }
}
