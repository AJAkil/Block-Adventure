using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player; //A reference to the player object
    public Text scoretext; //A reference to the text object field that is displayed on the screen

    public float offset = 49.12f;

    // Update is called once per frame
    void Update()
    {
        scoretext.text = (player.position.z+offset).ToString("0"); //This assigns the position of the player to the text on screen
    }
}
