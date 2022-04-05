using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction2 : MonoBehaviour
{
    SwitchRotation2 switchRotation2;
    MeshRenderer meshRenderer;
    [SerializeField]
    public bool isTurnedOn2;


    private void Awake()
    {
        switchRotation2 = GetComponent<SwitchRotation2>();
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Highlight the button to show that it is interactable
    public void HoverEntered()
    {
        meshRenderer.material.color = Color.blue;
    }

    public void HoverExited()
    {
        meshRenderer.material.color = Color.black;
    }

    // Rotates the button 
    public void IsActivated()
    {
        switchRotation2.IsOn();
        if (gameObject.tag == "correctButton2")
        {
            isTurnedOn2 = true;
        }
    }

    public void IsDeactivated()
    {
        switchRotation2.IsOff();
    }
}
