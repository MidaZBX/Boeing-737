using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchRotation : MonoBehaviour
{
    public void IsOn()
    {
        transform.eulerAngles = new Vector3(-114,-180, 90);
    }

    public void IsOff()
    {
        transform.eulerAngles = new Vector3(-114, -180, 270);
    }
}
