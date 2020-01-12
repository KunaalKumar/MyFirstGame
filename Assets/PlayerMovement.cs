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
            playerBody.AddForce(transform.forward * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            transform.Rotate(new Vector3(0, -50 * Time.deltaTime, 0));
        }
        if (Input.GetKey("s"))
        {
            playerBody.AddForce(-transform.forward * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(new Vector3(0, 50 * Time.deltaTime, 0));
        }
        if (Input.GetKeyUp("space"))
        {
            playerBody.AddForce(transform.up * movementSpeed);
        }
    }
}
