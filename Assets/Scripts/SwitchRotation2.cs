using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchRotation2 : MonoBehaviour
{
    public void IsOn()
    {
        transform.eulerAngles = new Vector3(-165, -70, 30);
    }

    public void IsOff()
    {
        transform.eulerAngles = new Vector3(-150, 0, 0);
    }
}
