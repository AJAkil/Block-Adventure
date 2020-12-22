using System.Collections;

using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    // Start is called before the first frame update
    //It will run when the game starts

    //These are the components of the rigid body or a reference to a rigid body
    public Rigidbody rb;


    public float forwardForce = 2000f; //forward force variable
    public float sideForce = 500f;
    public float upForce = 0.20f;
    


    public float end_markersR = 7f; //Denotes the border beyond which the game is over
    public float end_markersL = -7f;

    /*void Start()
    {
        rb.AddForce(0,300,400);
        
    }*/

    // Update is called once per frame
    void FixedUpdate() //using phyics stuff we use fixed_update instead of only update
    {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sideForce* Time.deltaTime , 0 , 0, ForceMode.VelocityChange);

        }else if (Input.GetKey("a"))
        {

            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);


        }else if(Input.GetKey("space"))
        {
            rb.AddForce(0, upForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            
        }

        if ((rb.position.x> end_markersR || rb.position.x<end_markersL) && rb.position.y<-1f)
        {
            
            FindObjectOfType<GameManager_script>().EndGame(); //Finding by object and ending the game if the player falls of the screen

        }
        
        
    }
}
