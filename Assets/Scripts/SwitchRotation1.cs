using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchRotation1 : MonoBehaviour
{
    public void IsOn()
    {
        transform.eulerAngles = new Vector3(-200, -180, 0); 
    }

    public void IsOff()
    {
        transform.eulerAngles = new Vector3(-150, 5, 0);
    }

}
