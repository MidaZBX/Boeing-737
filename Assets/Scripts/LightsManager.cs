using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LightsManager : MonoBehaviour
{
    public GameObject button;
    public GameObject button1;
    public GameObject button2;
    AudioSource audioSource;

    bool isPlayed = false;
    bool isPlayed1 = false;
    bool isPlayed2 = false;
    [SerializeField]
    public AudioClip correct;

    [SerializeField]
    Light[] lights;


    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

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
            if (!isPlayed)
            {
                audioSource.PlayOneShot(correct, 1);
                isPlayed = true;
            }
        } else
        {
            lights[0].color = Color.yellow;
        }

        if (button1.GetComponent<Interaction1>().isTurnedOn1)
        {
            lights[1].color = Color.green;
            if (!isPlayed1)
            {
                audioSource.PlayOneShot(correct, 1);
                isPlayed1 = true;
            }
        }
        else
        {
            lights[1].color = Color.yellow;
        }

        if (button2.GetComponent<Interaction2>().isTurnedOn2)
        {
            lights[2].color = Color.green;
            if (!isPlayed2)
            {
                audioSource.PlayOneShot(correct, 1);
                isPlayed2 = true;
            }
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
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
