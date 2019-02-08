using UnityEngine;

public class Movement : MonoBehaviour
{
    //reference to the rigidbody componant 
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sideForce = 500f;
    public int size = 1000;
    // Update is called once per frame
    void Update()
    {
        //adds a forward force to the player and can change according to the user
        //rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //player moves to the right
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0,0, size*forwardForce * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0,0,-size*forwardForce * Time.deltaTime);
        }
        if (Input.GetKey("g"))
        {
            rb.AddForce(0,size * forwardForce * Time.deltaTime,0);
        }
        if (Input.GetKey("b"))
        {
            rb.AddForce(0, -size * forwardForce * Time.deltaTime, 0);
        }




        //player moves to the left
        if (Input.GetKey("a"))
        {
            //x, y, z axis
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0);
        }
        

    }
}
