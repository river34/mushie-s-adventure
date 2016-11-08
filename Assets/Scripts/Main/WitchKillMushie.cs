using UnityEngine;
using System.Collections;

public class WitchKillMushie : MonoBehaviour {

    public GameObject mushie;

    GameObject controller;

    void Start ()
    {
        controller = GameObject.Find("Root");
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Mushie"))
        {
            controller.GetComponent<SceneController>().GoToDeathScene();
        }
    }
}
