using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchRotation : MonoBehaviour
{
    public void IsOn()
    {
        transform.Rotate(0, 0, 450);
    }

    public void IsOff()
    {
        transform.Rotate(0, 0, 270);
    }
}
