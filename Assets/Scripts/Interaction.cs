using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    SwitchRotation switchRotation;
    MeshRenderer meshRenderer;
    [SerializeField]
    public bool isTurnedOn;

    private void Awake()
    {
        switchRotation = GetComponent<SwitchRotation>();
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Highlight the button to show that it is interactable
    public void HoverEntered()
    {
        meshRenderer.material.color = Color.blue;
    }

    public void HoverExited()
    {
        meshRenderer.material.color = Color.red;
    }

    // Rotates the button 
    public void IsActivated()
    {
        switchRotation.IsOn();
        if (gameObject.CompareTag("correctButton"))
        {
            isTurnedOn = true;
        }
    }

    public void IsDeactivated()
    {
        switchRotation.IsOff();
        if (gameObject.CompareTag("correctButton"))
        {
            isTurnedOn = false;
        }
    }
}
