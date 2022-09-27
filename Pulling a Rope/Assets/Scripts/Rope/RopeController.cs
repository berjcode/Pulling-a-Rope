using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Rope.Scripts.RopeController{
public class RopeController : MonoBehaviour
{
   public static RopeController Instance {get; private set;}
   public int Value {get; set;}


   [SerializeField] private Vector2 minMaxVerticalPosition;
   [SerializeField] private Vector2 minMaxValue;
  

void Awake()
{
    Instance = this;
}

 void FixedUpdate()
 {
    var position = transform.position;
    var normalize = Mathf.InverseLerp(minMaxValue.x, minMaxValue.y,Value);
    var verticalPosition =Mathf.Lerp(minMaxVerticalPosition.x,minMaxVerticalPosition.y,normalize);
    var currentVerticalPosition = Mathf.Lerp(transform.position.y,verticalPosition,0.1f);
    
    position.y = currentVerticalPosition;
    transform.position = position;


    if(Mathf.Abs(Mathf.Abs(transform.position.y) - Mathf.Abs(minMaxVerticalPosition.y)) < 0.1f)
    {
        Debug.Log("Finish");
    }
 }
}
}