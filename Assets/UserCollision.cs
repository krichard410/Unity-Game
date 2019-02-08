//using UnityEngine library
using UnityEngine;

public class UserCollision : MonoBehaviour
{
    //public or private, type of script, name
    public Movement movement;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        //using tags to group elements if needed
        if(collisionInfo.collider.name == "Cube")
        {
            //player stops when they hit an obstacle
            movement.enabled = false;
        }
    }
}
