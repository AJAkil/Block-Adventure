using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{

    public float downForce = 10f;

    public Rigidbody rb;

    private void FixedUpdate()
    {

         if (!Input.GetKey("space") && rb.position.y > 2)
        {
            rb.AddForce(0, -downForce * Time.deltaTime, 0, ForceMode.VelocityChange);

        }

    }
}
