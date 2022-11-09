using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    //Variable to store the staring position of the background
    Vector3 startPos;
    //Variable to repeat the width of the background
    float repeatWidth;
    // Start is called before the first frame update
    void Start()
    {
        //Makes the startPos = to the position of the background
        startPos = transform.position;
        //Uses the box collider to get the exact position of half the background
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        //Makes the background repeat
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;

        }
    }
}
