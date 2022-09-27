using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using  Rope.Scripts.RopeController;

public class ClickController : MonoBehaviour, IPointerDownHandler
{

    [SerializeField] private int pullValue = 10;
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("CLİCK");
        RopeController.Instance.Value += pullValue; 
    }
}
