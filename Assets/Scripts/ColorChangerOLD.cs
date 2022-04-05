using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ColorChangerOLD : MonoBehaviour
{
    public Material orangeMaterial;
    public Material redMaterial;
    public Material greenMaterial;

    private MeshRenderer meshRenderer;
    private XRSimpleInteractable simpleInteractable;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        simpleInteractable = GetComponent<XRSimpleInteractable>();
        /* Now accepts an event instead of a method 
        simpleInteractable.onHoverEnter.AddListener(SetOrange);
        simpleInteractable.onHoverExit.AddListener(SetRed);
        simpleInteractable.onActivate.AddListener(SetGreen);
        simpleInteractable.onDeactivate.AddListener(SetRed);
        */
    }

    private void SetOrange(XRBaseInteractor interactor)
    {
        meshRenderer.material = orangeMaterial;
    }

    private void SetRed(XRBaseInteractor interactor)
    {
        meshRenderer.material = redMaterial;
    }
    private void SetGreen(XRBaseInteractor interactor)
    {
        meshRenderer.material = greenMaterial;
    }
}
