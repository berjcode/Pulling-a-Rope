using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
 
   public float speed = 10f;
   public float rightSpeed = 20f;

   private float horizontalInput;
   private float verticalInput; 
    

    
    void Update()
    {
       horizontalInput = Input.GetAxis("Horizontal");
       verticalInput = Input.GetAxis("Vertical");
       transform.Translate(Vector3.forward* Time.deltaTime *speed *verticalInput );
       transform.Rotate(Vector3.up,horizontalInput * rightSpeed*Time.deltaTime);
     
       
    }
}
