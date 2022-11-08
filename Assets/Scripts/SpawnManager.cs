using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Variable for the obstacle
    public GameObject obstaclePrefab;
    //Variable declarting the spawn position of the obstable
    Vector3 spawnPos = new Vector3(25, 0, 0);

    //Variable for the start time and the repeat time
    float startDelay = 2f;
    float repeatRate = 2.5f;
    PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        //Spawns in the Obstacle every 2 seconds
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);

        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Method to Instantantiate the obstacle at a certain position while keeping the currnt rotation  
    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
