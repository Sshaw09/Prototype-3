using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    float speed = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        //Translate/Moves the object to the left 
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
