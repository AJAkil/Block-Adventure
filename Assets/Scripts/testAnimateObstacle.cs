using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testAnimateObstacle : MonoBehaviour
{ 
    bool bouncer = true;
    float bouncespeed = 12f;
    bool bounceup = true;

    //public Rigidbody TestObstacle;

    public Rigidbody TestObstacle; //reference to the transform stuffs

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        if(bounceup)
        {
            //change the position of the object upwards
            TestObstacle.AddForce(0, bouncespeed * Time.deltaTime, 0, ForceMode.VelocityChange);
            
            if (TestObstacle.position.y > 7) bounceup = false;

        }
        else if(!bounceup)
        {
            Debug.Log(bounceup);
            TestObstacle.AddForce(0, -2 * Time.deltaTime, 0, ForceMode.VelocityChange);
            if (TestObstacle.position.y < 10) bounceup = true;

        }

    }
    
       
}
