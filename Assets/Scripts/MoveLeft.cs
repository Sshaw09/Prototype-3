using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    float speed = 30;
    PlayerController playerControllerScript;

    float leftBound = -15f;
    // Start is called before the first frame update
    void Start()
    {
        //makes a reference to the playercontroller script
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame

    void Update()
    {
        //Makes it so that when the game is over,everything stops moving
        if(playerControllerScript.gameOver == false)
        {
            //Translate/Moves the object to the left 
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        //Out of bounds; Makes it so that when the Obstacle goes past the bounds it gets destroyed
        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }

    }
}
