using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovementWindows : MonoBehaviour
{
    public Quaternion angle;

    public float forceval = 350f;

    Rigidbody rigidBody;    // declaring variable rigidBody of type RigidBody data type. 

    AudioSource carSound;   //declaring variable rocketSound of type AudioSource

    [SerializeField] float moveCarForce = 100f;   //f states that 100 is a floating no.  rcs stands for rection control system
                                               //variable to control speed of rocket

    //Serializing private field lets you control it in Unity Inspector

    [SerializeField] float mainAcceleartion = 100f;   //mainThrust variable to change the thrust of ship depending on it's mass

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();       //GetComponent is a functions which fetches RigidBodies here

        //carSound = GetComponent<AudioSource>();   //Getcomponent fetches AudioSource to play

        //rigidBody.freezeRotation = true;

        //rigidBody.constraints = RigidbodyConstraints.FreezeRotationY;

    }

    // Update is called once per frame
    void Update()
    {
        Accelerate();          // Function which handles thrusting of rocket

        

    }
    // Unity uses left handed system, this means pressing A turns anti-clockwise
    //and pressing D, turns clockwise direction

    //Vector3 is a struct which stores the coordinates of the bodies

    public void Accelerate()       //Function which handles Acceleartion of Car
    {
        

        
        if (Input.GetKey(KeyCode.UpArrow))   //KeyCode is an enum where all the key values of keyboard are stored
        {
            rigidBody.AddForce(new Vector3(0,-1,0) * mainAcceleartion);          // Press Space for Thrusting the rocket upwards
            
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidBody.AddForce(new Vector3(0, 1, 0) * mainAcceleartion);          // Press Space for Thrusting the rocket upwards
            

        }


        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidBody.AddForce(new Vector3(-1, 0, 0) * mainAcceleartion);          // Press Space for Thrusting the rocket upwards
          

        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidBody.AddForce(new Vector3(1, 0, 0) * mainAcceleartion);          // Press Space for Thrusting the rocket upwards           

        }

        else if (Input.GetKey(KeyCode.RightControl))
        {
            rigidBody.AddForce(new Vector3(0, 1, 0) * mainAcceleartion);          // Press Space for Thrusting the rocket upwards
            

        }

        else if (Input.GetKey(KeyCode.LeftControl))
        {
            rigidBody.AddForce(new Vector3(0, -1, 0) * mainAcceleartion);          // Press Space for Thrusting the rocket upwards
            

        }


        else if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, 1, 0) * mainAcceleartion*Time.deltaTime);     //To rotate in clockwise direction (+y axis)


        }

        else if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(-new Vector3(0, 1, 0) * mainAcceleartion * Time.deltaTime);     //To rotate in clockwise direction (+y axis)


        }


    }

    /*

    void ReduceSpeed()
    {
        rigidBody.AddRelativeForce(new Vector3(0, 0, -1) * forceval);

        Debug.Log("Speed Changed");
    }

    void ChangeAngle()
    {

        angle.eulerAngles = new Vector3(0, -170, 0);

        Debug.Log("Angle Changed");
    }

    public void ResetPosCar()
    {
        this.gameObject.transform.position = new Vector3(801.478f, 48.353f, 109.761f);
    }

    //Check for Collision with Trigger and Reduce the speed of Car and change angle in other Medium
    private void OnTriggerEnter(Collider other)
    {
        ReduceSpeed();
        ChangeAngle();
    }

    */
}
