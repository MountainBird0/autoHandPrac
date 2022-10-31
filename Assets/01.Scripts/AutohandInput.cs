using UnityEngine;
using Autohand;

public class AutoHandInput : MonoBehaviour
{
    public Hand leftHand;

    public void OnEnable()
    {
        leftHand.OnBeforeGrabbed += OnBeforeGrabbed;
    }   

    public void OnBeforeGrabbed(Hand hand, Grabbable grab)
    {
        Debug.Log("BeforeGrab");
    }
}
