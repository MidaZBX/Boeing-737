using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject[] buttons;
    private int currentButton;

    void Start()
    {
        currentButton = 0;

        for (int i = 1; i < buttons.Length; i++)
        {
            buttons[i].gameObject.GetComponent<Light>().enabled = false;
        }

        if (buttons.Length > 0)
        {
            buttons[0].gameObject.GetComponent<Light>().enabled = true;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentButton++;
            if (currentButton < buttons.Length)
            {
                buttons[currentButton - 1].gameObject.GetComponent<Light>().enabled = false;
                buttons[currentButton].gameObject.GetComponent<Light>().enabled = true;
            }
            else
            {
                buttons[currentButton - 1].gameObject.GetComponent<Light>().enabled = false;
                currentButton = 0;
                buttons[currentButton].gameObject.GetComponent<Light>().enabled = true;
            }
        }
    }
}
