using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LightsManager : MonoBehaviour
{
    public GameObject button;
    public GameObject button1;
    public GameObject button2;

    [SerializeField]
    Light[] lights;

    private void Update()
    {
        TurnLightsOn();
        CheckButtons();
    }

   
    void TurnLightsOn()
    {
        if (button.GetComponent<Interaction>().isTurnedOn)
        {
            lights[0].color = Color.green;
        } else
        {
            lights[0].color = Color.yellow;
        }

        if (button1.GetComponent<Interaction1>().isTurnedOn1)
        {
            lights[1].color = Color.green;
        }
        else
        {
            lights[1].color = Color.yellow;
        }

        if (button2.GetComponent<Interaction2>().isTurnedOn2)
        {
            lights[2].color = Color.green;
        }
        else
        {
            lights[2].color = Color.yellow;
        }
    }

    void CheckButtons()
    {
        if (button.GetComponent<Interaction>().isTurnedOn && button1.GetComponent<Interaction1>().isTurnedOn1 && button2.GetComponent<Interaction2>().isTurnedOn2)
        {
            Debug.Log("You have taken off successfully!");
            //SceneManager.LoadScene();
        }
    }
}
