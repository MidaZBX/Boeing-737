using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchRotation : MonoBehaviour
{
    public void IsOn()
    {
        //transform.rotation = new Quaternion(0, 0, 450, 0); // may be better 
        transform.Rotate(0, 0, 450); // it adds this amount to the current rotation 
    }

    public void IsOff()
    {
        transform.Rotate(0, 0, 270);
    }
}
