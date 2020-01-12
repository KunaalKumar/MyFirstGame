using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody playerBody;
    public float movementSpeed = 2000f;

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey("w"))
        {
            playerBody.AddForce(0, 0, movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            playerBody.AddForce(-movementSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            playerBody.AddForce(0, 0, -movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            playerBody.AddForce(movementSpeed * Time.deltaTime, 0, 0);
        }
    }

}
