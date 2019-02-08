using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform user;
    public Vector3 offset;
    //stores 3 floats

    // Update is called once per frame
    void Update()
    {
        //moving the camera to the user position plus the offset which brings the camera to a better angle
        transform.position = user.position + offset;
    }
}
