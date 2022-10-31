using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Autohand;

public class InputManager : MonoBehaviour
{
    public Hand rightHand;

    public void OnEnable()
    {
        rightHand.OnGrabbed += OnGrabbed1;
        rightHand.OnGrabbed += OnGrabbed2;
    }

    public void OnDisable()
    {
        rightHand.OnGrabbed -= OnGrabbed1;
        rightHand.OnGrabbed -= OnGrabbed2;
    }

    public void OnGrabbed1(Hand hand, Grabbable grab)
    {
        Debug.Log("Grab1");
    }

    public void OnGrabbed2(Hand hand, Grabbable grab)
    {
        Debug.Log("Grab2");
    }
        
    public void Grab()
    {
        Debug.Log("Grab3");
    }
}
