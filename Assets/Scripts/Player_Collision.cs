using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Collision : MonoBehaviour
{

    public Player_movement movement;
   // public GameManager_script manager; This will work but for ending the game and respawning the reference would be destroyed

    void OnCollisionEnter(Collision collisionInfo)
    {
         //collisionInfo is the object that we pass in the function
        //we extract various information from it such as collider name, force etc.

        if(collisionInfo.collider.tag == "Obstacle" )
        {
            movement.enabled = false;
            FindObjectOfType<GameManager_script>().EndGame(); //This lets us find objects from other script files easily
         
        }



    }


}
