using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    // Start is called before the first frame update
AudioSource audiogoal;

    void Start()
    {
        audiogoal=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision){
        if(collision.transform.tag=="Ball"){
            Debug.Log("Goal Scored");
            audiogoal.Play();
        }
    }
}
