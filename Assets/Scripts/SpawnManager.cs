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
    float startDelay = 2;
    float repeatRate = 2;
    // Start is called before the first frame update
    void Start()
    {
        //Spawns in the Obstacle every 2 seconds
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Method to Instantantiate the obstacle at a certain position while keeping the currnt rotation  
    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);

    }
}
