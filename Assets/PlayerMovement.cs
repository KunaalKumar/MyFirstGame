using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody playerBody;
    public float movementSpeed = 2000f;
    public float turnSpeed=5;
    Animator animator;

    public GameObject weapon;

    void Start(){
        playerBody=GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey("w"))
        {
            Debug.Log("Key down");
            animator.SetBool("isWalking", true);
            playerBody.AddForce(transform.forward*10);
        }

        if(Input.GetKeyUp("w")) {
            Debug.Log("Key up");
            animator.SetBool("isWalking", false);
        }

        if (Input.GetKey("a"))
        {
            //playerBody.AddForce(-movementSpeed * Time.deltaTime, 0, 0);
           transform.Rotate(new Vector3(0,-turnSpeed,0));
            // playerBody.AddTorque(new Vector3(0,-turnSpeed,0));
        }
        if (Input.GetKey("s"))
        {
            //playerBody.AddForce(0, 0, -movementSpeed * Time.deltaTime);
            playerBody.AddForce(-transform.forward*10);
        }
        if (Input.GetKey("d"))
        {
            //playerBody.AddForce(movementSpeed * Time.deltaTime, 0, 0);
            transform.Rotate(new Vector3(0,turnSpeed,0));
            // playerBody.AddTorque(new Vector3(0,turnSpeed,0));
        }
    }

    void Update(){
        if(Input.GetMouseButtonUp(0)){
            Debug.Log("called");
            animator.SetTrigger("Kick");
        }
    }

}
