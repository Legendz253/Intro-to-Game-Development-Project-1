using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    public float speed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Store the current position value of the in game object.
        Vector3 temp = this.transform.position;
        
        //This adds the value of speed to the objects x position.
        temp.x += speed * Time.deltaTime;

        //set the new position by transforming the position (teleporting) of the object by very small amounts.
        this.transform.position = temp;
    }
}
