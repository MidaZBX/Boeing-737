using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction1 : MonoBehaviour
{
    SwitchRotation1 switchRotation1;
    MeshRenderer meshRenderer;
    [SerializeField]
    public bool isTurnedOn1;

    private void Awake()
    {
        switchRotation1 = GetComponent<SwitchRotation1>();
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
        switchRotation1.IsOn();
        if (gameObject.tag == "correctButton1")
        {
            isTurnedOn1 = true;
        }
    }

    public void IsDeactivated()
    {
        switchRotation1.IsOff();
        if (gameObject.tag == "correctButton1")
        {
            isTurnedOn1 = false;
        }
    }
}
