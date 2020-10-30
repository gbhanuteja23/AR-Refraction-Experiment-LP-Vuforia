using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovementAndroid : MonoBehaviour
{
    Rigidbody rigidBody;

    //AudioSource audioSource;

    public float rcsThrust = 350f;

    float rotateThisFrame;

    public float forceval = 350f;

    public Quaternion angle;


    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();       

        //audioSource = GetComponent<AudioSource>();       

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
    public void ThrustUpward()
    {
        if (!audioSource.isPlaying)  
        {
            audioSource.Play();    
        }

        else
        {
            audioSource.Stop();   
        }

        rigidBody.AddRelativeForce(new Vector3(0,0,1) * forceval);
    }

    public void ThrustDownward()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }

        else
        {
            audioSource.Stop();   
        }

        rigidBody.AddRelativeForce( new Vector3(0,0,-1) * forceval);
    }

    */

    public void MoveLeft()
    {
        
        rigidBody.AddRelativeForce(new Vector3(-1, 0, 0) * forceval);
    }

    public void MoveRight()
    {

        rigidBody.AddRelativeForce(new Vector3(1, 0, 0) * forceval);
    }

    public void MoveForward()
    {
        transform.Translate(new Vector3(0, 0, 1) * 5, Space.Self);
        
        //rigidBody.AddRelativeForce(new Vector3(0, 0, 1) * forceval);
        //rigidBody.AddForce(new Vector3(0, 0, 1) * forceval, ForceMode.Acceleration);
    }

    public void Movebackward()
    {
        transform.Translate(new Vector3(0, 0, -1) * 5, Space.Self);
        
        //rigidBody.AddRelativeForce(new Vector3(0, 0, -1) * forceval);
        //rigidBody.AddForce(new Vector3(0, 0, -1) * forceval, ForceMode.Acceleration);
    }

    public void RotateClockwise_x()
    {
        rotateThisFrame = rcsThrust * Time.deltaTime;

        transform.Rotate(new Vector3(0, 1, 0) * rotateThisFrame);
    }
    

    public void RotateAntiClockwise_x()
    {
        rotateThisFrame = rcsThrust * Time.deltaTime;

        transform.Rotate(-new Vector3(0, 1, 0) * rotateThisFrame);
    }

    public void RotateClockwise_y()
    {
        rotateThisFrame = rcsThrust * Time.deltaTime;

        transform.Rotate(new Vector3(0, 1, 0) * rotateThisFrame);
    }


    public void RotateAntiClockwise_y()
    {
        rotateThisFrame = rcsThrust * Time.deltaTime;

        transform.Rotate(-new Vector3(0, 1, 0) * rotateThisFrame);
    }

    public void RotateClockwise_z()
    {
        rotateThisFrame = rcsThrust * Time.deltaTime;

        transform.Rotate(new Vector3(1, 0, 0) * rotateThisFrame);
    }


    public void RotateAntiClockwise_z()
    {
        rotateThisFrame = rcsThrust * Time.deltaTime;

        transform.Rotate(-new Vector3(1, 0, 0) * rotateThisFrame);
    }

    void ReduceSpeed()
    {
        rigidBody.AddRelativeForce(new Vector3(0, 0, -1) * forceval);

        //rigidBody.velocity = new Vector3(0, 0, 0.5f);

        Debug.Log("Speed Changed");
    }

    void ChangeAngle()
    {
        
        angle.eulerAngles = new Vector3(0, -170, 0);

        Debug.Log("Angle Changed");
    }

    public void ResetPosCar()
    {
        this.gameObject.transform.position = new Vector3(0.02189f, 0.07914f, -0.42794f);

        this.gameObject.transform.rotation = Quaternion.Euler(-0.007f, -369.591f, -0.625f);

        rigidBody.velocity = new Vector3(0,0,0);
    }
    
    //Check for Collision with Trigger and Reduce the speed of Car and change angle in other Medium
    private void OnTriggerEnter(Collider other)
    {
        ReduceSpeed();
        ChangeAngle();
    }
}
