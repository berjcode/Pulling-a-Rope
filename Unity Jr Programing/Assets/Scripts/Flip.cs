using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
   [SerializeField] private GameObject spin;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spin.transform.Rotate(0f,0f,90f,Space.World);
      //  spin.transform.Rotate(xAngle, yAngle, zAngle, Space.World);
    }
}
