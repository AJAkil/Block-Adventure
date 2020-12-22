using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public Transform player; //reference to the transform stuffs

    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset; //here the "transform" is the reference to the main camera and by this 
                                             //assignment we added the position of the player to the camera so that the camera follows the platyer
        
    }
}
