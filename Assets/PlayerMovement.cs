using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody playerBody;
    //public float movementSpeed = 2000f;
    public float turnSpeed=5;
    //public float maxSpeed=50;
    public float kickingPower=50;
    Animator animator;
    bool isKicking=false;


    void Start(){
        playerBody=GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKeyDown("w"))
        {
            Debug.Log("Key down");
            animator.SetBool("isWalking", true);           
        }

        if(Input.GetKey("w")){
            playerBody.AddForce(transform.forward*10);
        }

        if(Input.GetKeyUp("w")) {
            Debug.Log("Key up");
            playerBody.AddForce(-transform.forward*playerBody.velocity.magnitude*0.5f,ForceMode.VelocityChange);
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
        // if(Input.GetKeyUp(KeyCode.Space)){
        //     animator.SetTrigger("Sliding");
        // }
    }

    void OnCollisionEnter(Collision collision){
        if(collision.transform.tag=="Ball" && isKicking){       //Kick direction uses a mix of the direction the player is facing and contact point data
            kickingPower=kickingPower+playerBody.velocity.z*0.2f;
            foreach(ContactPoint contact in collision){
                collision.transform.GetComponent<Rigidbody>().AddForce(-contact.normal*kickingPower*0.5f+transform.forward*kickingPower*0.5f+Vector3.up*kickingPower*0.16f,ForceMode.VelocityChange);
            }
            isKicking=false;
        }
    }

    public void Kicking(){
        isKicking=true;
    }

    public void DoneKicking(){
        isKicking=false;
    }    
}
