using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody playerBody;
    public float movementSpeed = 2000f;
    public float turnSpeed=5;

    public GameObject weapon;

    void Start(){
        playerBody=GetComponent<Rigidbody>();
    }

    // void Update(){
    //     if(Input.GetMouseButtonUp(0)){
    //         weapon.SetActive(true);
    //         StartCoroutine("ResetWeapon");
    //     }
    // }

    // IEnumerator ResetWeapon(){
    //     yield return new WaitForSeconds(2);
    //     weapon.SetActive(false);
    // }


    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey("w"))
        {
            playerBody.AddForce(transform.forward*10);
        }
        if (Input.GetKey("a"))
        {
            //playerBody.AddForce(-movementSpeed * Time.deltaTime, 0, 0);
           // transform.Rotate(new Vector3(0,-turnSpeed,0));
            playerBody.AddTorque(new Vector3(0,-turnSpeed,0));
        }
        if (Input.GetKey("s"))
        {
            //playerBody.AddForce(0, 0, -movementSpeed * Time.deltaTime);
            playerBody.AddForce(-transform.forward*10);
        }
        if (Input.GetKey("d"))
        {
            //playerBody.AddForce(movementSpeed * Time.deltaTime, 0, 0);
            //transform.Rotate(new Vector3(0,turnSpeed,0));
            playerBody.AddTorque(new Vector3(0,turnSpeed,0));
        }
    }

}
